using FeedBackPortal.Data;
using FeedBackPortal.Models;
using Microsoft.EntityFrameworkCore;

public interface ICategoryService  //  Define CategoryService interface
{
    Task<List<Category>> GetAllCategoriesAsync(); //  Method signature: returns task (async operation) which will produce List of Category objects
}

public class CategoryService : ICategoryService
{
    private readonly AppDbContext _context; //  Interacts with database

    public CategoryService(AppDbContext context)  //  Constructor. Takes instance of AppDbContext and assigns to _context. (Dependency Injection)
    {
        _context = context;
    }

    public async Task<List<Category>> GetAllCategoriesAsync() //  Implementation of GetAllCategoriesAsync from ICategoryService implementation.
    {
        return await _context.Categories.ToListAsync();
    }
}

