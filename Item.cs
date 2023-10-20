using System;
namespace exerLista
{
    public class Item
    {
        private string? _conteudo;
        public string? Conteudo { get => _conteudo; set => _conteudo = value; }

        public string Exibir()
        {
            return $"------------------- ITEM ------------------- \n[Item]: {this.Conteudo}";
        }
    }
}