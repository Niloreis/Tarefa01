using Tarefa02.Entities;

namespace pedido
    
{
    public class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\n ***DADOS DO PEDIDO*** \n");
            var pedido = new Pedido();
            pedido.Cliente = new Cliente();
            pedido.Endereco = new Endereco(); 
            
            pedido.Id = Guid.NewGuid();
            pedido.Cliente.Id = Guid.NewGuid();
            pedido.Endereco.Id = Guid.NewGuid();

            Console.Write("DATA DO PEDIDO.........: ");
                pedido.Datadopedido = Convert.ToDateTime(Console.ReadLine());

            Console.Write("VALOR DO PEDIDO........:");
            pedido.Valor =Convert.ToDecimal (Console.ReadLine());

            Console.Write("NOME DO CLIENTE........:");
            pedido.Cliente.Nome = Console.ReadLine();

            Console.Write("CPF....................:");
            pedido.Cliente.Cpf =Console.ReadLine();

            Console.Write("EMAIL..................::");
            pedido.Cliente.Email = Console.ReadLine();

            Console.Write("TELEFONE...............:");
            pedido.Cliente.Telefone= Console.ReadLine();

            Console.Write("LOGRADOURO.............:");
            pedido.Endereco.Logradouro = Console.ReadLine();

            Console.Write("COMPLEMENTO............:");
            pedido.Endereco.Complemento = Console.ReadLine();

            Console.Write("BAIRRO.................");
            pedido.Endereco.Bairro = Console.ReadLine();

            Console.Write("CIDADE.................:");
            pedido.Endereco.Cidade = Console.ReadLine();

            Console.Write("ESTADO.................:");
            pedido.Endereco.Estado = Console.ReadLine();

            Console.Write("CEP....................:");
            pedido.Endereco.Cep= Console.ReadLine();







            //PEDIDO//
            Console.WriteLine("\n***RECIBO***");
            Console.WriteLine($"\tID DO PEDIDO........:{pedido.Id}");
            Console.WriteLine($"\tDATA DO PEDIPO......:{pedido.Datadopedido}");
            Console.WriteLine($"\tVALOR DO PEDIDO........:{pedido.Valor}");
            //CLIENTE//
            Console.WriteLine($"\tID DO CLIENTE........:{pedido.Cliente.Id}");
            Console.WriteLine($"\tNOME DO CLIENTE........:{pedido.Cliente.Nome}");
            Console.WriteLine($"\tCPF........:{pedido.Cliente.Cpf}");
            Console.WriteLine($"\tEMAIL........:{pedido.Cliente.Email}");
            Console.WriteLine($"\tTELEFONE........:{pedido.Cliente.Telefone}");
            //ENDEREÇO//

            Console.WriteLine($"\tID DO ENDEREÇO.........:{pedido.Endereco.Id}");
            Console.WriteLine($"\tLOGRADOURO.............: {pedido.Endereco.Logradouro}");
            Console.WriteLine($"\tCOMPLEMENTO............:{pedido.Endereco.Complemento}");
            Console.WriteLine($"\tBAIRRO.................:{pedido.Endereco.Bairro}");
            Console.WriteLine($"\tCIDADE.................:{pedido.Endereco.Cidade}");
            Console.WriteLine($"\tESTADO.................:{pedido.Endereco.Estado}");
            Console.WriteLine($"\tCEP....................:{pedido.Endereco.Cep}");
           



        }
    }




}



