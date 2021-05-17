using System;
using System.Collections.Generic;

public class Apresentacao
{
	public Apresentacao()
	{
		rotas = new List<string>();
		rotas.Add("/clientes");
	}

	private List<string> rotas { get; set; }

	public string Mensagem { get { return "Seja bem vindo a nossa API"; } }
	public List<string> Rotas { get { return this.rotas; } }
}
