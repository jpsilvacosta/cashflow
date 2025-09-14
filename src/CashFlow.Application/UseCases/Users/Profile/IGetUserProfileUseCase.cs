using AutoMapper;
using CashFlow.Communication.Responses;
using CashFlow.Domain.Services.LoggedUser;

namespace CashFlow.Application.UseCases.Users.Profile
{
    public interface IGetUserProfileUseCase
    {
        Task<ResponseUserProfileJson> Execute();
    }
}