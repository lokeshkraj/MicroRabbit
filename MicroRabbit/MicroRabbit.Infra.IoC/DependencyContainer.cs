﻿using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Application.Services;
using MicroRabbit.Banking.Data.Contexts;
using MicroRabbit.Banking.Data.Repository;
using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Infra.Bus;
using Microsoft.Extensions.DependencyInjection;

namespace MicroRabbit.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Event bus
            services.AddTransient<IEventBus, RabbitMQBus>();

            //Application
            services.AddTransient<IAccountService, AccountService> ();

            //Data
            services.AddTransient<IAccountRepository, AccountsRepository>();
            services.AddTransient<BankingDBContext>();

         
        }
    }
}
