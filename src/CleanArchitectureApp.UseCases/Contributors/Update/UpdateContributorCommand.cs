using Ardalis.Result;
using Ardalis.SharedKernel;

namespace CleanArchitectureApp.UseCases.Contributors.Update;

public record UpdateContributorCommand(int ContributorId, string NewName) : ICommand<Result<ContributorDTO>>;
