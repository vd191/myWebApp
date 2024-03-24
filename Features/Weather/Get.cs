using MediatR;
using myWebApp.Data;

namespace Features.Weather;
public class Get : IRequest<string>
{
    public class Handler : IRequestHandler<Get, string>
    {
        private readonly SchoolContext _context;
        public Handler(SchoolContext context)
        {
            _context = context;
        }
        public Task<string> Handle(Get request, CancellationToken cancellationToken)
        {
            var s = _context.Students?.Where(d => d.ID == 1).FirstOrDefault();
            var fullname = $"{s?.FirstName} {s?.LastName}";
            return Task.FromResult(fullname);
        }
    }
}