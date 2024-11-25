﻿using System.Globalization;

namespace Program {
    class Produto {

    private string _nome;
    private double _preco;
    private int _quantidade;

    public Produto(){
    }

    public Produto(string nome, double preco, int quantidade){
        _nome = nome;
        _preco = preco;
        _quantidade = quantidade;
    }

    public string GetNome(){
        return _nome;
    }

    public void SetNome(string nome){
        if (nome != null && nome.Length > 1){
            _nome = nome;
        }
    }

    public double GetPreco(){
        return _preco;
    }

    public double GetQuantidade(){
        return _quantidade;
    }

    public double ValorTotalEmEstoque(){
        return _preco * _quantidade;
    }

    public void AdicionarProdutos(int quantidade){
        _quantidade += quantidade;
    }

    public void RemoverProdutos(int quantidade){
        _quantidade -= quantidade;
    }

    public override string ToString(){
            return _nome
            + ", R$ "
            + _preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + _quantidade
            + " unidades, Total: R$ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
