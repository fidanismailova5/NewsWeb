using Application.DTOs;
using Application.Models;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Contracts
{
	public interface IUsers : IGenericRepository<Users>
	{
		Task<TokensModel> LoginAsync(LoginModel login, CancellationToken cancellationToken);

		Task<TokensModel> AddToRoleAsync(string roleName, string email, CancellationToken cancellationToken);

		Task<TokensModel> UpdateAsync(string email, UsersDto userDto, CancellationToken cancellationToken);
	}
}
