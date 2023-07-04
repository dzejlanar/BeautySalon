using BeautySalon.Model.ViewModels;

namespace BeautySalon.Services.Interfaces
{
    public interface IRecommendationService
    {
        List<ServiceVM> Recommend(int userId);
        Task CreateModel();
    }
}
