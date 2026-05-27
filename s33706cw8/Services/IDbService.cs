using Microsoft.AspNetCore.Mvc;
using s33706cw8.DTOs;
using s33706cw8.Entities;

namespace s33706cw8.Services;

public interface IDbService
{
    Task<object> GetPatients();
}