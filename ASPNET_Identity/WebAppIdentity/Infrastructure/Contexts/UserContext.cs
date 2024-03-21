using Infrastructure.Enitities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Contexts;

public class UserContext(DbContextOptions<UserContext> options) : IdentityDbContext<UserEntity>(options)
{
}
