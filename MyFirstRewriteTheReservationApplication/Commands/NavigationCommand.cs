using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MyFirstRewriteTheReservationApplication.Commands
{
    public class NavigationCommand : CommandBase
    {
        public override void Execute(object? parameter)
        {
            MessageBox.Show("haha");
        }
    }
}
