using GovUK.Dfe.ExternalApplications.Api.Client;
using GovUK.Dfe.ExternalApplications.Api.Client.Contracts;
using GovUK.Dfe.ExternalApplications.Api.Client.Extensions;
using GovUK.Dfe.LocalSendReformPlans.Application.Interfaces;
using GovUK.Dfe.LocalSendReformPlans.Infrastructure.Parsers;
using GovUK.Dfe.LocalSendReformPlans.Infrastructure.Providers;
using GovUK.Dfe.LocalSendReformPlans.Infrastructure.Services;
using GovUK.Dfe.LocalSendReformPlans.Infrastructure.Stores;
using GovUK.Dfe.LocalSendReformPlans.Web.Services;
using GovUK.Dfe.LocalSendReformPlans.Web.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GovUK.Dfe.LocalSendReformPlans.Web.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddExternalApplicationsApiClients(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddExternalApplicationsApiClient<ITokensClient, TokensClient>(configuration);
            services.AddExternalApplicationsApiClient<IUsersClient, UsersClient>(configuration);
            services.AddExternalApplicationsApiClient<IApplicationsClient, ApplicationsClient>(configuration);
            services.AddExternalApplicationsApiClient<ITemplatesClient, TemplatesClient>(configuration);
            services.AddExternalApplicationsApiClient<IHubAuthClient, HubAuthClient>(configuration);
            services.AddExternalApplicationsApiClient<INotificationsClient, NotificationsClient>(configuration);
            services.AddExternalApplicationsApiClient<IUserFeedbackClient, UserFeedbackClient>(configuration);
            return services;
        }

        public static IServiceCollection AddWebLayerServices(this IServiceCollection services)
        {
            // Web layer services
            services.AddScoped<IFieldRendererService, FieldRendererService>();
            services.AddScoped<IFormErrorStore, FormErrorStore>();

            // Infrastructure/application services used by web
            services.AddScoped<IApplicationResponseService, ApplicationResponseService>();
            services.AddScoped<IFieldFormattingService, FieldFormattingService>();
            services.AddScoped<ITemplateManagementService, TemplateManagementService>();
            services.AddScoped<IApplicationStateService, ApplicationStateService>();
            services.AddScoped<IFileUploadService, FileUploadService>();
            services.AddScoped<IAutocompleteService, AutocompleteService>();
            services.AddScoped<IComplexFieldConfigurationService, ComplexFieldConfigurationService>();
            services.AddScoped<IComplexFieldRendererFactory, ComplexFieldRendererFactory>();
            services.AddScoped<IComplexFieldRenderer, AutocompleteComplexFieldRenderer>();
            services.AddScoped<IComplexFieldRenderer, CompositeComplexFieldRenderer>();
            services.AddScoped<IComplexFieldRenderer, UploadComplexFieldRenderer>();
            services.AddSingleton<ITemplateStore, ApiTemplateStore>();
            services.AddSingleton<IFormTemplateParser, JsonFormTemplateParser>();
            services.AddScoped<IFormTemplateProvider, FormTemplateProvider>();
            
            // Form Engine Services
            services.AddScoped<IFormStateManager, FormStateManager>();
            services.AddScoped<IFormNavigationService, FormNavigationService>();
            services.AddScoped<INavigationHistoryService, NavigationHistoryService>();
            services.AddScoped<IFormDataManager, FormDataManager>();
            services.AddScoped<IFieldRequirementService, FieldRequirementService>();
            services.AddScoped<IFormValidationOrchestrator, GovUK.Dfe.LocalSendReformPlans.Infrastructure.Services.FormValidationOrchestrator>();
            services.AddScoped<IFormConfigurationService, FormConfigurationService>();
            services.AddScoped<ITemplateValidationService, TemplateValidationService>();
            services.AddHttpContextAccessor();
            
            // Confirmation Services
            services.AddScoped<IButtonConfirmationService, ButtonConfirmationService>();
            services.AddScoped<IConfirmationDataService, ConfirmationDataService>();
            
            // Feedback services
            services.AddScoped<IFeedbackService, FeedbackService>();
            
            return services;
        }
    }
}


