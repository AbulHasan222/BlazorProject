using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.IdentityModel.Tokens;
using SecurityAuthManager.Contracts;
using SecurityAuthManager.Repositories;
using System.Text;
using SessionUpdManager;
using UserAppSecurity.Contacts;
using UserAppSecurity.Repositories;
using Axurance.Repositories.Contacts;
using Axurance.Repositories.Repo;


namespace FintechHub.UI.Configuration
{
    public static class ConfigurationServices
    {
        public static void ConfigureCors(this IServiceCollection services, IConfiguration config)
        {

            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder =>
                    {
                        builder.AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader();
                    });
            });
        }
        public static void ConfigureJWTAuthentication(this IServiceCollection services, IConfiguration conguration)
        {
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateIssuerSigningKey = true,
                    ValidateLifetime = true,
                    ValidIssuer = conguration["Jwt:Issuer"],
                    ValidAudience = conguration["Jwt:Audience"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(conguration["Jwt:key"]!))
                };
            });
        }

        public static void ConfigureIISIntegration(this IServiceCollection services)
        {
            services.Configure<IISOptions>(options =>
            {

            });
        }

       

        public static void ConfigureRepositoryWrapper(this IServiceCollection services)
        {
            services.AddTransient<IUSER_REG, USER_REG_REPO>();
            services.AddScoped<TokenAdminManager.TokenManagement.ITokenGen, TokenAdminManager.TokenManagement.TokenGenerationRepo>();
            services.AddScoped<AuthenticationStateProvider, TokenAdminManager.TokenManagement.AuthenticationStateProviderRepo>();
           
            services.AddSingleton<TokenAdminManager.TokenManagement.IDistributedCacheManager, TokenAdminManager.TokenManagement.DistributedCacheManager>();
            services.AddScoped<ISessionService, SessionService>();
            services.AddScoped<IEncryptionService, EncryptionService>();
            services.AddTransient<IClientSessionContext, ClientSessionContext>();
            services.AddTransient<IUserAccess, UserAccessRepo>();
			services.AddTransient<IHRMOffice, HRMOffice>();

		}

        public static void ConfigureJsonNamingConvention(this IServiceCollection services)
        {
            services.AddControllers().AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.PropertyNamingPolicy = null;
            });
        }
    }
}
