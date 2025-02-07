﻿using InnerCircle.Authentication.Data.Queries;

namespace InnerCircle.Authentication.Data.Commands;

public class UserUnblockCommand
{
    private readonly AppDbContext _context;
    private readonly GetUserQuery _getUserQuery;

    public UserUnblockCommand(AppDbContext context, GetUserQuery getUserQuery)
    {
        _context = context;
        _getUserQuery = getUserQuery;
    }

    public async Task ExecuteAsync(long accountId)
    {
        var user = await _getUserQuery.GetUserByAccountIdAsync(accountId);
        user.IsBlocked = false;
        await _context.SaveChangesAsync();
    }
}