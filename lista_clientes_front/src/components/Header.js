import { Component } from 'react';

class Header extends Component {
  render() {
      return (
        <header class="navbar navbar-expand-md navbar-dark bd-navbar">

          <link href="https://getbootstrap.com/docs/5.0/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-wEmeIV1mKuiNpC+IOBjI7aAzPcEZeedi5yW5f2yOq55WWLwNGmvvx4Um1vskeMj0" crossorigin="anonymous"></link>

          <link href="https://getbootstrap.com/docs/5.0/assets/css/docs.css" rel="stylesheet"></link>

          <nav class="container-xxl flex-wrap flex-md-nowrap" aria-label="Main navigation">
            <a class="navbar-brand p-0 me-2" href="/" aria-label="Bootstrap">
            </a>

            {/* <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#bdNavbar" aria-controls="bdNavbar" aria-expanded="false" aria-label="Toggle navigation">
              <svg xmlns="http://www.w3.org/2000/svg" width="32" height="32" class="bi" fill="currentColor" viewBox="0 0 16 16">
                <path fill-rule="evenodd" d="M2.5 11.5A.5.5 0 0 1 3 11h10a.5.5 0 0 1 0 1H3a.5.5 0 0 1-.5-.5zm0-4A.5.5 0 0 1 3 7h10a.5.5 0 0 1 0 1H3a.5.5 0 0 1-.5-.5zm0-4A.5.5 0 0 1 3 3h10a.5.5 0 0 1 0 1H3a.5.5 0 0 1-.5-.5z"></path>
              </svg>

            </button> */}

            <div class="collapse navbar-collapse" id="bdNavbar">
              <ul class="navbar-nav flex-row flex-wrap bd-navbar-nav pt-2 py-md-0">
                <li class="nav-item col-6 col-md-auto">
                  <a class="nav-link p-2" href="/" >Home</a>
                </li>
                <li class="nav-item col-6 col-md-auto">
                  <a class="nav-link p-2" href="/clientes" >Clientes</a>
                </li>
              </ul>

              <hr class="d-md-none text-white-50"></hr>

              <ul class="navbar-nav flex-row flex-wrap ms-md-auto">
                <li class="nav-item col-6 col-md-auto">
                  <a class="nav-link p-2" href="https://github.com/AmandaRH07" target="_blank" rel="noopener">
                    <small class="d-md-none ms-2">GitHub</small>
                  </a>
                </li>
              </ul>
            </div>
          </nav>
        </header>
      );
    }
  }

  export default Header;
