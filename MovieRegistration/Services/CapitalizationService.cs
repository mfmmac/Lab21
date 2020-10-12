using MovieRegistration.Models;

namespace MovieRegistration.Services
{
    public interface ICapitalizationService
    {
        MovieRegistrationResultViewModel Capitalize(MovieRegistrationViewModel viewModel);
    }

    public class CapitalizationService : ICapitalizationService
    {
        public MovieRegistrationResultViewModel Capitalize(MovieRegistrationViewModel viewModel)
        {
            return new MovieRegistrationResultViewModel
            {
                Title = viewModel.Title.ToUpper(),
                Genere = viewModel.Genere.ToUpper(),
                Year = viewModel.Year.ToUpper(),
                Actors = viewModel.Actors.ToUpper(),
                Directors = viewModel.Directors.ToUpper(),
                Result = viewModel.Title + " has been registered."
            }; 
        }
    }
}
