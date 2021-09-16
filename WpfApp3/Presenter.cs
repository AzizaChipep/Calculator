using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3
{
    class Presenter
    {
        Model model;
        MainWindow mainWindow;

        public Presenter(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
            this.model = new Model();
            this.mainWindow.PlusEvent += mainWindow_PlusEvent;
            this.mainWindow.MinusEvent += mainWindow_MinusEvent;
            this.mainWindow.MultiplyEvent += mainWindow_MultiplyEvent;
            this.mainWindow.DivideEvent += mainWindow_DivideEvent;

        }

        private void mainWindow_PlusEvent(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(this.mainWindow.first_operand.Text);
            int b = Convert.ToInt32(this.mainWindow.second_operand.Text);
            this.mainWindow.result.Text = this.model.PlusMethod(a,b);
            
        }

        private void mainWindow_MinusEvent(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(this.mainWindow.first_operand.Text);
            int b = Convert.ToInt32(this.mainWindow.second_operand.Text);
            this.mainWindow.result.Text = this.model.MinusMethod(a, b);
        }

        private void mainWindow_MultiplyEvent(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(this.mainWindow.first_operand.Text);
            int b = Convert.ToInt32(this.mainWindow.second_operand.Text);
            this.mainWindow.result.Text = this.model.MultiplyMethod(a, b);
        }

        private void mainWindow_DivideEvent(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(this.mainWindow.first_operand.Text);
            int b = Convert.ToInt32(this.mainWindow.second_operand.Text);
            this.mainWindow.result.Text = this.model.DivideMethod(a, b);
        }
    }

}
