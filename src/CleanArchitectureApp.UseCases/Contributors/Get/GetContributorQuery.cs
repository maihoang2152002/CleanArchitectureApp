using Ardalis.Result;
using Ardalis.SharedKernel;

namespace CleanArchitectureApp.UseCases.Contributors.Get;

public record GetContributorQuery(int ContributorId) : IQuery<Result<ContributorDTO>>;
