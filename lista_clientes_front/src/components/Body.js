import { Component } from 'react';

class Body extends Component {
  render() {
    return (
      <main>
        <div class="bd-masthead mb-3" id="content">
          <div class="container px-4 px-md-3">
            <div class="row align-items-lg-center">
              <div class="col-md-8 order-md-1 col-lg-7 text-center text-md-start">
                <h1 class="mb-3">Uma aplicação criada com ReactJS</h1>
                <p class="lead mb-4">
                  Por conseguinte, a adoção de políticas descentralizadoras possibilita uma melhor visão global das novas proposições.
                </p>

                <div class="d-flex flex-column flex-md-row">
                  <a href="/clientes" class="btn btn-lg btn-bd-primary mb-3 me-md-3" >Cadastrar clientes</a>
                </div>
                <p class="text-muted mb-0">
                  Currently <strong>v0.0.1</strong>
                  <span class="px-1">·</span>
                </p>
              </div>
            </div>
          </div>
        </div>
      </main>
    );
  }
}

export default Body;
