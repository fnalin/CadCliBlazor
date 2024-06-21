using CadCliBlazor.Domain.Contracts.Repositories;
using CadCliBlazor.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CadCliBlazor.Data.Repositories;

public class ClienteRepository (CadCliDbContext context) : IClienteRepository
{
    public async Task<IEnumerable<Cliente>> GetAllAsync()
    {
        return await context.Clientes.ToListAsync();
    }

    public async Task<Cliente> GetAsync(int id)
    {
        return await context.Clientes.FindAsync(id);
    }

    public async Task AddAsync(Cliente entity)
    {
       await context.Clientes.AddAsync(entity);
       await context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Cliente entity)
    {
         context.Clientes.Update(entity);
         await context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Cliente entity)
    {
        context.Clientes.Remove(entity);
        await context.SaveChangesAsync();
    }
}