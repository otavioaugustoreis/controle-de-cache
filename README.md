# Cache em ASP.NET Core 🚀

Este projeto tem como objetivo aprender e testar as funcionalidades de **Cache** no **ASP.NET Core**, explorando diferentes formas de armazenamento em cache para melhorar a performance das aplicações.

---

## 🧐 O que é Cache?

Cache é uma técnica utilizada para armazenar temporariamente dados frequentemente acessados, reduzindo a necessidade de consultas repetitivas a bancos de dados ou processamento pesado. No **ASP.NET Core**, podemos utilizar diferentes tipos de cache:

1. **Cache na Memória (`IMemoryCache`)** - Armazena dados na RAM do servidor.  
2. **Cache Distribuído (`IDistributedCache`)** - Usa Redis ou SQL Server para compartilhamento entre servidores.  
3. **Cache de Resposta (`Response Caching`)** - Armazena respostas HTTP para otimizar o tempo de resposta.

---

## 🛠 Tecnologias Utilizadas

- **C#**
- **ASP.NET Core 7**
- **IMemoryCache** (cache em memória)
- **IDistributedCache** (cache distribuído com Redis)
- **Response Caching Middleware** (cache de resposta HTTP)
- **Swagger** para testes de API

