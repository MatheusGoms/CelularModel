# CelularModel

Este projeto é uma implementação de um sistema que abstrai diferentes marcas e modelos de celulares, permitindo que cada um tenha seu próprio comportamento. O objetivo é demonstrar conceitos de Programação Orientada a Objetos (POO) e reutilização de código utilizando a linguagem C# e a plataforma .NET.

## Estrutura do Projeto

O repositório está organizado da seguinte forma:

CelularModel/
├── Celulares/
│   ├── Celular.cs          # Classe base para todos os celulares
│   ├── MarcaA/            # Modelos da Marca A
│   │   ├── ModeloA1.cs
│   │   └── ModeloA2.cs
│   └── MarcaB/            # Modelos da Marca B
│       ├── ModeloB1.cs
│       └── ModeloB2.cs
├── Testes/                # Testes automatizados
│   └── CelularTests.cs
├── CelularModel.sln       # Solução do Visual Studio
└── README.md              # Este arquivo


## Funcionalidades

- **Abstração:** Implementa uma classe base `Celular` contendo propriedades comuns (modelo, marca, sistema operacional) e métodos abstratos.
- **Herança:** Cada marca e modelo de celular herda da classe base, permitindo implementar comportamentos específicos.
- **Testes Automatizados:** Inclui testes para verificar o funcionamento correto das funcionalidades implementadas.

## Tecnologias Utilizadas

- **Linguagem:** C#
- **Framework:** .NET
- **IDE:** Visual Studio ou Visual Studio Code
- **Testes:** MSTest para testes automatizados

## Como Executar o Projeto

1. Clone o repositório:
   ```bash
   git clone https://github.com/seuusuario/CelularModel.git


Contribuições
Sinta-se à vontade para contribuir com o projeto! Você pode:

Criar novas classes para diferentes marcas e modelos de celulares.
Melhorar a documentação.
Adicionar novos testes para garantir a qualidade do código.
Licença
Este projeto está licenciado sob a MIT License - consulte o arquivo LICENSE para mais detalhes.

Contato
Se você tiver alguma dúvida ou sugestão, entre em contato comigo:

Nome: Matheus de Almeida Gomes
E-mail: matheus.ag9610@gmail.com
