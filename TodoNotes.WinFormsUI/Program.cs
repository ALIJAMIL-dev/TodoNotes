using System;
using System.Windows.Forms;
using Ninject;
using TodoNotes.Business.DependencyResolvers.Ninject;
using TodoNotes.Business.Abstract;

namespace TodoNotes.WinFormsUI
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Create DI container
            IKernel kernel = new StandardKernel(new BusinessModule());

            // Run main form with injected services
            Application.Run(new Form1(
                kernel.Get<ITodoItemService>(),
                kernel.Get<INoteService>()
            ));
        }
    }
}
