using System;

namespace LoggerApi.Domain.Models
{
    public class LoggerPagamentoModel
    {
        CartaoCreditoModel Cartao {get;set;}
        UsuarioModel Usuario {get;set;}
        public int NumeroPedido {get;set;}
    }
}