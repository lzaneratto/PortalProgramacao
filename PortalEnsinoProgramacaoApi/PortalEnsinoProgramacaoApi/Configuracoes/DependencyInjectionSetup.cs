using Microsoft.Extensions.DependencyInjection;
using PortalEnsinoProgramacao.Dominio.Interfaces;
using PortalEnsinoProgramacao.Infraestrutura.Data.DataContext;
using PortalEnsinoProgramacao.Infraestrutura.Data.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalEnsinoProgramacaoApi.Configuracoes
{
    public static class DependencyInjectionSetup
    {
        public static void AddDependencyInjection(this IServiceCollection services)
        {
            if (services is null) throw new ArgumentNullException(nameof(services));

            services.AddScoped<PortalEnsinoProgramacaoContexto>();
            services.AddTransient<IAlunoRepositorio, AlunoRepositorio>();
            services.AddTransient<IDisciplinaRepositorio, DisciplinaRepositorio>();
            services.AddTransient<IMaterialRepositorio, MaterialRepositorio>();
            services.AddTransient<IProfessorRepositorio, ProfessorRepositorio>();
            services.AddTransient<ITrabalhoRepositorio, TrabalhoRepositorio>();
            services.AddTransient<IUsuarioRepositorio, UsuarioRepositorio>();
        }

    }
}
