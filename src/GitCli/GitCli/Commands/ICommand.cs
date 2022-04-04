using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitCli.Commands
{
    internal interface ICommand
    {
        void Execute();
    }
}
