using AutoMapper;
using BeautySalon.Model.Requests;
using BeautySalon.Model.ViewModels;
using BeautySalon.Services.Database;
using Microsoft.Extensions.DependencyInjection;

namespace BeautySalon.Services.ServiceStateMachine
{
    public class BaseServiceState
    {
        public IServiceProvider _serviceProvider { get; set; }
        public BeautySalonContext _context { get; set; }
        public IMapper _mapper { get; set; }

        public BaseServiceState(IServiceProvider serviceProvider, BeautySalonContext context, IMapper mapper)
        {
            _serviceProvider = serviceProvider;
            _context = context;
            _mapper = mapper;
        }

        public virtual ServiceVM Insert(ServiceUpsertRequest request)
        {
            throw new Exception("Method not allowed.");
        }

        public virtual ServiceVM Update(int id, ServiceUpsertRequest request)
        {
            throw new Exception("Method not allowed.");
        }

        public virtual ServiceVM Activate(int id)
        {
            throw new Exception("Method not allowed.");
        }

        public virtual ServiceVM Hide(int id)
        {
            throw new Exception("Method not allowed.");
        }

        public virtual List<string> AllowedActions(Service? service)
        {
            return new List<string>();
        }

        public BaseServiceState CreateState(string status)
        {
            switch (status)
            {
                case "initial":
                    return _serviceProvider.GetService<InitialServiceState>();
                case "draft":
                    return _serviceProvider.GetService<DraftServiceState>();
                case "active":
                    return _serviceProvider.GetService<ActiveServiceState>();
                case "hidden":
                    return _serviceProvider.GetService<HiddenServiceState>();
                default: throw new Exception("State not recognized");
            }
        }
    }
}
