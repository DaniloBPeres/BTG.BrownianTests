# 🧪 BTG.BrownianMotionApp.Tests

Este projeto contém os **testes unitários** da aplicação principal [`BTG.BrownianMotionApp`](https://github.com/DaniloBPeres/BTG.BrownianMotianApp).

## 🎯 Objetivo

Validar os componentes centrais da simulação browniana com foco em:

- Lógica de geração das simulações
- Comportamento esperado diante de entradas válidas e inválidas
- Garantia de consistência na estrutura dos dados gerados

## 📚 Tecnologias

- [.NET 9](https://dotnet.microsoft.com/)
- [xUnit](https://xunit.net/) — framework de testes
- [FluentAssertions](https://fluentassertions.com/) — para assertivas legíveis e expressivas

## 🚀 Executando os testes

Para rodar os testes localmente:

```bash
cd BTG.BrownianMotionApp.Tests
dotnet test
```

## ✅ Testes implementados

| Teste                                                           | Descrição                                                        |
| --------------------------------------------------------------- | ---------------------------------------------------------------- |
| `Generate_ShouldReturnValidPaths_WhenCalledWithValidParameters` | Garante que caminhos válidos são gerados com parâmetros corretos |
| `Generate_WithInvalidParameters_ShouldReturnEmpty`              | Verifica que entradas inválidas não produzem simulações          |

## 📦 Dependências
```bash
dotnet add package xunit
dotnet add package xunit.runner.visualstudio
dotnet add package FluentAssertions
```
