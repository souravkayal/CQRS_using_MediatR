using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediateR_NetCore.Queries
{
    

    public class GetValuesQuery
    {
        public class Query : IRequest<IEnumerable<string>>
        {

        }

        public class Handler : RequestHandler<Query , IEnumerable<string>>
        {
            
            protected override IEnumerable<string> Handle(Query request)
            {
                return new List<string>() { "Items 1" };
            }
        
        }

    }
}
