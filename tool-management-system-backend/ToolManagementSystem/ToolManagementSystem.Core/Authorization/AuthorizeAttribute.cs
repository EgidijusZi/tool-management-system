﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using ToolManagementSystem.Core.Responses;
using ToolManagementSystem.Domain.Entities;

namespace ToolManagementSystem.Core.Authorization
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class AuthorizeAttribute : Attribute, IAuthorizationFilter
    {
        private readonly IList<Role> _roles;

        public AuthorizeAttribute(params Role[] roles)
        {
            _roles = roles ?? new Role[] { };
        }
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var allowAnonymous = context.ActionDescriptor.EndpointMetadata.OfType<AllowAnonymousAttribute>().Any();
            if (allowAnonymous)
                return;

            var user = (UserResponseDto)context.HttpContext.Items["User"];
            if (user == null || (_roles.Any() && !_roles.Contains(user.Role)))
            {
                context.Result = new JsonResult (new { message = "Unauthorized" }) { StatusCode = StatusCodes.Status401Unauthorized };
            }

        }
    }
}
