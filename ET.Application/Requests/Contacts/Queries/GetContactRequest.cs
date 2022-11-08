using Ardalis.Specification;
using ET.Domain.Entities;
using MediatR;

namespace ET.Application.Requests.Contacts.Queries;

public record GetContactRequest(int Id) : IRequest<ContactDto>;

public class ContactById : Specification<Contact, ContactDto>
{
    public ContactById(int Id)
    {
        Query.Where(q => q.Id == Id);
        Query.AsNoTracking();
    }
}

public class GetContactRequestHandler : IRequestHandler<GetContactRequest, ContactDto>
{
    private readonly IRepository<Contact> _repository;

    public GetContactRequestHandler(IRepository<Contact> repository) => _repository = repository;

    public Task<ContactDto> Handle(GetContactRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}