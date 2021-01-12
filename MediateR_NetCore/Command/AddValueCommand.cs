using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediateR_NetCore.Commands
{
    public class AddValueCommand
    {

        public class Command : IRequest
        {

        }

        public class Handler : RequestHandler<Command>
        {
            protected override void Handle(Command request)
            {
                Console.WriteLine("Command execute");
            }
        }

    }
}
