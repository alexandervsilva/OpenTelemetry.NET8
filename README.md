## Perfil

Consulte o meu perfil <a href="https://github.com/alexandervsilva/alexandervsilva/blob/master/README.md">aqui</a>.

[DOTNET_BADGE]:https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white
[AZURE_BADGE]:https://img.shields.io/badge/azure-%230072C6.svg?style=for-the-badge&logo=microsoftazure&logoColor=white
[CSHARP_BADGE]:https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=csharp&logoColor=white
[SWAGGER_BADGE]:https://img.shields.io/badge/-Swagger-%23Clojure?style=for-the-badge&logo=swagger&logoColor=white
[SQLSERVER_BADGE]:https://img.shields.io/badge/Microsoft%20SQL%20Server-CC2927?style=for-the-badge&logo=microsoft%20sql%20server&logoColor=white
[DATADOG_BADGE]:https://img.shields.io/badge/datadog-%23632CA6.svg?style=for-the-badge&logo=datadog&logoColor=white
[JAEGER_BADGE]:https://img.shields.io/badge/jaeger-%23632CA6.svg?style=for-the-badge&logo=jaeger&logoColor=white
[GRAFANA_BADGE]:https://img.shields.io/badge/grafana-%23632CA6.svg?style=for-the-badge&logo=grafana&logoColor=white
[PROMETHEUS_BADGE]:https://img.shields.io/badge/prometheus-%23632CA6.svg?style=for-the-badge&logo=prometheus&logoColor=white
[DYNATRACE_BADGE]:https://img.shields.io/badge/dynatrace-%23632CA6.svg?style=for-the-badge&logo=dynatrace&logoColor=white
[ZIPKIN_BADGE]:https://img.shields.io/badge/zipkin-%23632CA6.svg?style=for-the-badge&logo=zipkin&logoColor=white
[LOKI_BADGE]:https://img.shields.io/badge/loki-%23632CA6.svg?style=for-the-badge&logo=loki&logoColor=white

<h1 align="center" style="font-weight: bold;">OpenTelemetry 💻</h1>

![.Net][DOTNET_BADGE]
![C#][CSHARP_BADGE]
![Azure][AZURE_BADGE]
![Swagger][SWAGGER_BADGE]
![MicrosoftSQLServer][SQLSERVER_BADGE]
![Grafana][GRAFANA_BADGE]
![Prometheus][PROMETHEUS_BADGE]
![Datadog][DATADOG_BADGE]
![Dynatrace][DYNATRACE_BADGE]
![Jaeger][JAEGER_BADGE]
![Zipkin][ZIPKIN_BADGE]
![Loki][LOKI_BADGE]

## Índice

- [Índice](#índice)
- [Começo rápido](#começo-rápido)
- [Cenário atual](#cenário-atual)
- [Estrutura do repositório](#estrutura-do-repositório)
- [Erros e solicitações de recursos](#erros-e-solicitações-de-recursos)
- [Contribuição](#contribuição)
- [Criador](#criador)
- [Agradecimentos](#agradecimentos)
- [Direitos e licença](#direitos-e-licença)

## Começo rápido

# Instalando Ferramentas de Observabilidade ou Back-End

Neste guia, vamos instalar e configurar diversas ferramentas de observabilidade e back-end para monitoramento e rastreamento de aplicativos.

## 1. Instalando OpenTelemetry

O **OpenTelemetry** é uma biblioteca para instrumentação de observabilidade que permite coletar dados de rastreamento, métricas e logs. Para instalar o OpenTelemetry, siga as instruções na documentação oficial.

## 2. Instalação do Loki

O **Loki** é uma ferramenta de agregação de logs desenvolvida pela Grafana Labs, projetada para ser escalável e eficiente.

## 3. Instalação do Jaeger

O **Jaeger** é uma ferramenta de rastreamento distribuído usada para monitorar e solucionar problemas de sistemas distribuídos. É uma das ferramentas mais populares para rastreamento de aplicativos.

## 4. Instalação do Zipkin

O **Zipkin** é uma solução de rastreamento distribuído que ajuda a solucionar problemas em sistemas distribuídos. Pode ser usado em conjunto com o OpenTelemetry.

## 5. Instalação do Prometheus

O **Prometheus** é uma ferramenta de monitoramento de métricas com um poderoso modelo de dados de séries temporais. Ele é amplamente utilizado para monitoramento e alertas.

## 6. Instalação do Grafana

O **Grafana** é uma plataforma de análise e visualização de dados. Ele pode ser integrado ao Prometheus para criar dashboards personalizados e visualizar métricas e logs.

---

# Instrumentação Automática de Aplicativos .NET 8

A instrumentação automática permite coletar dados de métricas, logs e rastreamento sem alterações significativas no código-fonte do aplicativo.

## 1. Registro

O registro de eventos pode ser feito automaticamente utilizando bibliotecas de instrumentação, como o OpenTelemetry e ILogger do .NET.

## 2. Métricas

A coleta de métricas pode ser configurada automaticamente através do OpenTelemetry, integrando-se com ferramentas como Prometheus para monitorar métricas do aplicativo.

## 3. Rastreamento

A instrumentação automática de rastreamento é configurada para coletar dados de rastreamento distribuído de forma transparente, utilizando o OpenTelemetry com ferramentas como Jaeger ou Zipkin.

---

# Instrumentação Manual de Aplicativos .NET 8

A instrumentação manual é útil quando você deseja um controle mais detalhado sobre os pontos em que as métricas ou rastreamentos são coletados.

## 1. Métricas

A instrumentação manual de métricas envolve o uso de classes específicas, como **MeterProvider**, para criar e exportar métricas de eventos específicos no código.

## Cenário atual

Consulte a situação do projeto <a href="https://github.com/alexandervsilva/<meu-repositorio>/blob/master/README.md">aqui</a>.

## Estrutura do repositório

Veja como navegar entre pastas aqui:

```text
Projeto/
   └── src/
   │
   └── docs/        
   │
   └── tests/       
```

## Erros e solicitações de recursos
Tem um bug ou uma solicitação de recurso? Leia primeiro as [diretrizes do problema](https://reponame/blob/master/CONTRIBUTING.md)  e pesquise os problemas existentes e encerrados. [abra um novo problema](https://github.com/alexandervsilva/<meu-repositorio>/issues).

## Contribuição

Por favor, leia nossas [diretrizes de contribuição](https://reponame/blob/master/CONTRIBUTING.md). Estão incluídas instruções para abrir questões, padrões de codificação e notas sobre o desenvolvimento.

## Criador

- <https://github.com/alexandervsilva>

## Agradecimentos

Obrigado por consultar, divulgar ou contribuir.

## Direitos e licença

Código e documentação com copyright 2021 dos autores. Código divulgado sob a [MIT License](https://github.com/alexandervsilva/Repositorio.Modelo/blob/master/LICENSE).

<!--<p align="center">
 <a href="#started">Getting Started</a> • 
  <a href="#routes">API Endpoints</a> •
 <a href="#colab">Collaborators</a> •
 <a href="#contribute">Contribute</a>
</p>

<p align="center">
  <b>Simple description of what your project do or how to use it.</b>
</p>

<h2 id="started">🚀 Getting started</h2>

Here you describe how to run your project locally

<h3>Prerequisites</h3>

Here you list all prerequisites necessary for running your project. For example:

- [NodeJS](https://github.com/)
- [Git 2](https://github.com)

<h3>Cloning</h3>

How to clone your project

```bash
git clone your-project-url-in-github
```

<h3> Environment Variables</h2>

Use the `application.properties.example` as reference to create your configuration file `application.properties` with your AWS Credentials

```yaml
aws.region=us-east-1
aws.accessKeyId={YOUR_AWS_KEY_ID}
aws.secretKey={YOUR_AWS_SECRET}
```

<h3>Starting</h3>

How to start your project

```bash
cd project-name
npm some-command-to-run
``````


<h2 id="routes">📍 API Endpoints</h2>

Here you can list the main routes of your API, and what are their expected request bodies.
​
| route               | description                                          
|----------------------|-----------------------------------------------------
| <kbd>GET /authenticate</kbd>     | retrieves user info see [response details](#get-auth-detail)
| <kbd>POST /authenticate</kbd>     | authenticate user into the api see [request details](#post-auth-detail)

<h3 id="get-auth-detail">GET /authenticate</h3>

**RESPONSE**
```json
{
  "name": "Fernanda Kipper",
  "age": 20,
  "email": "her-email@gmail.com"
}
```

<h3 id="post-auth-detail">POST /authenticate</h3>

**REQUEST**
```json
{
  "username": "fernandakipper",
  "password": "4444444"
}
```

**RESPONSE**
```json
{
  "token": "OwoMRHsaQwyAgVoc3OXmL1JhMVUYXGGBbCTK0GBgiYitwQwjf0gVoBmkbuyy0pSi"
}
```

<h2 id="colab">🤝 Collaborators</h2>

Special thank you for all people that contributed for this project.

<table>
  <tr>
    <td align="center">
      <a href="#">
        <img src="https://avatars.githubusercontent.com/u/61896274?v=4" width="100px;" alt="Fernanda Kipper Profile Picture"/><br>
        <sub>
          <b>Fernanda Kipper</b>
        </sub>
      </a>
    </td>
    <td align="center">
      <a href="#">
        <img src="https://t.ctcdn.com.br/n7eZ74KAcU3iYwnQ89-ul9txVxc=/400x400/smart/filters:format(webp)/i490769.jpeg" width="100px;" alt="Elon Musk Picture"/><br>
        <sub>
          <b>Elon Musk</b>
        </sub>
      </a>
    </td>
    <td align="center">
      <a href="#">
        <img src="https://miro.medium.com/max/360/0*1SkS3mSorArvY9kS.jpg" width="100px;" alt="Foto do Steve Jobs"/><br>
        <sub>
          <b>Steve Jobs</b>
        </sub>
      </a>
    </td>
  </tr>
</table>

<h2 id="contribute">📫 Contribute</h2>

Here you will explain how other developers can contribute to your project. For example, explaining how can create their branches, which patterns to follow and how to open an pull request

1. `git clone https://github.com/Fernanda-Kipper/text-editor.git`
2. `git checkout -b feature/NAME`
3. Follow commit patterns
4. Open a Pull Request explaining the problem solved or feature made, if exists, append screenshot of visual modifications and wait for the review!-->

<h3>Documentações que podem ajudar</h3>

[📝 Como criar um Pull Request](https://www.atlassian.com/br/git/tutorials/making-a-pull-request)

[💾 Commit pattern](https://gist.github.com/joshbuchea/6f47e86d2510bce28f8e7f42ae84c716)
