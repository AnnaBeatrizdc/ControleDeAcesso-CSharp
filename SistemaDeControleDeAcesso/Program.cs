
string senhaCorreta = "1234";
int tentativas = 0;
bool autenticado = false;

List<string> usuarios = new List<string>
{
    "Ana",
    "Eduardo",
    "Maria",
    "João",
    "Pedro"
};

string perfil = "Visitante";
int opcao;

while (tentativas < 3 && !autenticado)
{
    Console.Write("Digite a senha: ");
    string? senhaDigitada = Console.ReadLine();

    if (senhaDigitada == senhaCorreta)
    {
        Console.WriteLine("Acesso liberado");
        autenticado = true;
    }
    else
    {
        Console.WriteLine("Senha incorreta");
        tentativas++;
    }
}

if (!autenticado)
{
    Console.WriteLine("Limite de tentativas atigindas!");
}

if (autenticado)
{
    do
    {
        Console.WriteLine("=== MENU ===");
        Console.WriteLine("1 - Cadastrar usuário");
        Console.WriteLine("2 - Listar usuários");
        Console.WriteLine("3 - Consoltar permissões");
        Console.WriteLine("4 - Gerar relatório");
        Console.WriteLine("0 - Sair");

        Console.Write("Escolha uma opção: ");
        string? entrada = Console.ReadLine();

        if (!int.TryParse(entrada, out opcao)) // Verifica se a entrada é um número inteiro.
        {
            opcao = -1;
        }
        switch (opcao)
        {
            case 1:
                Console.WriteLine("=== CADASTRO ===");
                Console.Write("Insira o seu nome: ");
                string? novoUsuario = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(novoUsuario))
                {
                    Console.WriteLine("Usuario adicionado com sucesso!");
                    usuarios.Add(novoUsuario.Trim());
                }
                else
                {
                    Console.WriteLine("Nome inválido!");
                }
                break;

            case 2:
                Console.WriteLine("=== USUÁRIOS ===");

                foreach (string usuario in usuarios)
                {
                    Console.WriteLine(usuario);
                }

                break;

            case 3:
                int opcaoDePermissao;
                do
                {
                    Console.WriteLine("=== PERMISSÕES ===");
                    Console.WriteLine("1 - Admin");
                    Console.WriteLine("2 - Moderador");
                    Console.WriteLine("3 - Usuario");
                    Console.WriteLine("0 - Voltar");

                    Console.Write("Escolha uma opção: ");
                    string? entradaDePermissoes = Console.ReadLine();
                    if (!int.TryParse(entradaDePermissoes, out opcaoDePermissao))
                    {
                        opcaoDePermissao = -1;
                    }
                    switch (opcaoDePermissao)
                    {
                        case 1:
                            Console.WriteLine("Permissão de Admin");
                            break;

                        case 2:
                            Console.WriteLine("Permissão de Moderado");
                            break;

                        case 3:
                            Console.WriteLine("Permissão de Usuario");
                            break;

                        case 0:
                            Console.WriteLine("Voltando...");
                            break;

                        default:
                            Console.WriteLine("Opção inválida!");
                            break;
                    }
                }
                while (opcaoDePermissao != 0);

                break;

            case 4: 
                Console.WriteLine("=== RELATÓRIO ==="); 
                for (int i = 1; i <= 3; i++) 
                { 
                    switch (i) 
                    { 
                        case 1: 
                            Console.WriteLine(".....Usuarios....."); 
                            foreach (string usuario in usuarios) 
                            { 
                                Console.WriteLine(usuario); 
                            }
                            Console.WriteLine($"Total de usuários: {usuarios.Count}");
                            break; 
                        case 2: 
                            if (perfil == "Admin") 
                            { 
                                Console.WriteLine("Acesso completo"); 
                            } 
                            else if (perfil == "Moderador") 
                            { 
                                Console.WriteLine("Acesso para consultar e moderar"); 
                            }
                            else if (perfil == "Usuario")
                            {
                                Console.WriteLine("Acesso somente para consulta");
                            }
                            else 
                            { 
                                Console.WriteLine("Perfil desconhecido"); 
                            } 
                            break;
                        case 3:
                            Console.WriteLine("Relatorio concluído!");
                            break;
                    } 
                } 
                break;

            case 0:
                Console.WriteLine("Encerrando...");
                break;

            default:
                Console.WriteLine("Opção inválida!");
                break;
        }
    }
    while (opcao != 0);
}
