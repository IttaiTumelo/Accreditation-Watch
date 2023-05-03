System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
//Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddScoped<IProgramService, ProgramService>();
builder.Services.AddScoped<ISchoolService, SchoolService>();
builder.Services.AddScoped<IDepartmentService, DepartmentService>();
builder.Services.AddScoped<IAccrediteService, AccrediteService>();
builder.Services.AddScoped<IPendingImplimentationService, PendingImplimentationService>();
builder.Services.AddScoped<AuthenticationStateProvider, CBUAuthService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<IAccrediteStatusService, AccrediteStatusService>();
builder.Services.AddScoped<IHistoryService, HistoryService>();
builder.Services.AddScoped<IAWTaskService, AWTaskService>();
builder.Services.AddScoped<IProblemService, ProblemService>();
builder.Services.AddScoped<INoteService, NoteService>();
builder.Services.AddScoped<INoteMessageService, NoteMessageService>();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
//in charge of authorization
builder.Services.AddAuthorizationCore();
//in charge of local storage and token storage on the browser
builder.Services.AddBlazoredLocalStorage();

await builder.Build().RunAsync();

