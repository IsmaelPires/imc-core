using IMC.Aplicacao.Interfaces;
using IMC.Aplicacao.Servicos;
using IMC.Dominio.Interfaces.Repositorios;
using IMC.Dominio.Interfaces.Servicos;
using IMC.Dominio.Servicos;
using IMC.Infra.Data.Repositorios;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace IMC.Infra.IoC
{
    public class InjetorDependencias
    {
        public static void Registrar(IServiceCollection svcCollection)
        {
            //Aplicação
            svcCollection.AddScoped(typeof(IAppBase<,>), typeof(ServicoAppBase<,>));
            svcCollection.AddScoped<IUsuarioApp, UsuarioApp>();

            //Domínio
            svcCollection.AddScoped(typeof(IServicoBase<>), typeof(ServicoBase<>));
            svcCollection.AddScoped<IUsuarioServico, UsuarioServico>();

            //Repositorio
            svcCollection.AddScoped(typeof(IRepositorioBase<>), typeof(RepositorioBase<>));
            svcCollection.AddScoped<IUsuarioRepositorio, UsuarioRepositorio>();
        }
    }
}
