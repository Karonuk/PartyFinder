using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PartyFinder.BLL.User.Command.LoginCommand
{
    public class LoginCommand : IRequest<string>
    {

        public class LoginCommandHandler : IRequestHandler<LoginCommand, string>
        {
            public async Task<string> Handle(LoginCommand request, CancellationToken cancellationToken)
            {
                return "it's fucking works";
            }
        }
    }
}
