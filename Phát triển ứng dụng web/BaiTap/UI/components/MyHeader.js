const myHeader = document.createElement("template");

myHeader.innerHTML = `
  <link
  rel="stylesheet"
  href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.4.2/css/all.min.css"
  />
  <link
  href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css"
  rel="stylesheet"
  integrity="sha384-T3c6CoIi6uLrA9TneNEoa7RxnatzjcDSCmG1MXxSR1GAsXEV/Dwwykc2MPK8M2HN"
  crossorigin="anonymous"
  />
  <script
  src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.bundle.min.js"
  integrity="sha384-C6RzsynM9kWDrMNeT87bh95OGNyZPhcTNXj1NW7RuBCsyN/o0jlpcV8Qyq46cDfL"
  crossorigin="anonymous"
  ></script>
  <style type="text/css">
    @import url(./global.css);

    header {
      height: 90px;
      border-bottom: 1px solid #333;
    }
    .logo {
      & img {
        padding: 5px;
        width: auto;
        height: 90px;
      }
    }
    .main-nav_container {
      & a {
        color: #333;
        text-decoration: none;
        font-weight: 600;
        letter-spacing: 1.5px;
        &:hover {
          color: var(--main-color) !important;
          background: #eee;
        }
      }
      & ul {
        list-style: none;
        font-size: 1.8rem;

        & a {
          padding: 1.6rem 2.4rem;
        }
      }
    }
    .search-bar {
      & form {
        position: relative;

        & line {
          display: none;
          position: absolute;
          height: 100%;
          border: 2.5px solid var(--main-color);
        }
        .search-content {
          font-size: 1.6rem;
          width: 200px;
          color: #333;
          border: 1px solid #ccc;
          border-right: none;

          &::placeholder {
            color: #ccc;
          }

          &:focus {
            outline: none;
            & ~ line {
              display: block;
            }
          }
        }
        .search-btn {
          font-size: 1.8rem;
          color: #ccc;
          padding: 5px 1.6rem;
          border: 1px solid #ccc;
          border-left: none;
          transition: all linear 0.3s;

          &:hover {
            color: #fff;
            background-color: var(--main-color);
            border-color: var(--main-color);
          }
        }
      }
    }
    .user_container {
      padding: 0 1.6rem;

      .item {
        padding: 0 1.6rem;
        & a {
          width: 2.4rem;
          height: 2.4rem;
          & i {
            font-size: 2.4rem;
            color: #444;
          }
        }
      }
      .user-acc_wrapper {
        width: 42px;
        height: 42px;
        & a {
          border: 2px solid #333;
          border-radius: 999px;
        }
      }
    }
    .mode_container {
      margin-left: 5rem;
      .item {
        color: #333;
        :hover {
          cursor: pointer;
        }
      }
      .item.hidden {
        display: none;
      }
    }

    header.dark-theme {
      border-bottom: 1px solid #858585;
      
      & i {
        color: var(--font-color_dark-theme) !important;
      }

      .user-acc_wrapper {
        & a {
          border: 2px solid var(--font-color_dark-theme);
        }
      }
      .mode_container {
        .item {
          color: var(--font-color_dark-theme);
        }
      }
    }
  </style>
`;

myHeader.innerHTML += `
  <header class="d-flex justify-content-center">
    <div class="logo">
      <a href="./"
        ><img
          src="https://gongcha.com.vn/wp-content/uploads/2018/03/Untitled-4.png"
          alt=""
      /></a>
    </div>
    <div class="main-nav_container d-flex">
      <ul class="d-flex align-items-center px-5 m-0">
        <li><a href="">Trang chủ</a></li>
        <li><a href="">Giới thiệu</a></li>
        <li>
          <a href="">Thực đơn</a>
          <!-- <div>
            Nội dung thực đơn
          </div> -->
        </li>
        <li><a href="">Tin tức</a></li>
      </ul>
    </div>
    <div class="search-bar_container d-flex align-items-center">
      <div class="search-bar">
        <form action="./handle" method="get" class="d-flex">
          <input
            type="text"
            name=""
            id=""
            class="search-content px-4 py-2 lh-lg"
            placeholder="Tìm kiếm"
          />
          <button type="submit" class="search-btn btn rounded-0">
            <i class="fa-solid fa-magnifying-glass"></i>
          </button>
          <line></line>
        </form>
      </div>
    </div>
    <div class="user_container d-flex align-items-center">
      <div class="item">
        <div class="user-acc_wrapper item p-0">
          <a
            href=""
            class="d-flex align-items-center justify-content-center w-100 h-100"
            ><i class="fa-solid fa-user"></i
          ></a>
        </div>
      </div>
      <div class="item">
        <div class="user-cart_wrapper">
          <a href="">
            <i class="fa-solid fa-cart-shopping"></i>
          </a>
        </div>
      </div>
    </div>
    <div class="mode_container d-flex align-items-center">
      <div class="change-mode" onclick="toggleDarkTheme();">
        <div class="item">
          <svg
            xmlns="http://www.w3.org/2000/svg"
            width="24"
            height="24"
            fill="currentColor"
            class="bi bi-moon-stars-fill"
            viewBox="0 0 16 16"
          >
            <path
              d="M6 .278a.768.768 0 0 1 .08.858 7.208 7.208 0 0 0-.878 3.46c0 4.021 3.278 7.277 7.318 7.277.527 0 1.04-.055 1.533-.16a.787.787 0 0 1 .81.316.733.733 0 0 1-.031.893A8.349 8.349 0 0 1 8.344 16C3.734 16 0 12.286 0 7.71 0 4.266 2.114 1.312 5.124.06A.752.752 0 0 1 6 .278z"
            />
            <path
              d="M10.794 3.148a.217.217 0 0 1 .412 0l.387 1.162c.173.518.579.924 1.097 1.097l1.162.387a.217.217 0 0 1 0 .412l-1.162.387a1.734 1.734 0 0 0-1.097 1.097l-.387 1.162a.217.217 0 0 1-.412 0l-.387-1.162A1.734 1.734 0 0 0 9.31 6.593l-1.162-.387a.217.217 0 0 1 0-.412l1.162-.387a1.734 1.734 0 0 0 1.097-1.097l.387-1.162zM13.863.099a.145.145 0 0 1 .274 0l.258.774c.115.346.386.617.732.732l.774.258a.145.145 0 0 1 0 .274l-.774.258a1.156 1.156 0 0 0-.732.732l-.258.774a.145.145 0 0 1-.274 0l-.258-.774a1.156 1.156 0 0 0-.732-.732l-.774-.258a.145.145 0 0 1 0-.274l.774-.258c.346-.115.617-.386.732-.732L13.863.1z"
            />
          </svg>
        </div>
        <div class="item hidden">
          <svg
            xmlns="http://www.w3.org/2000/svg"
            width="24"
            height="24"
            fill="currentColor"
            class="bi bi-brightness-high-fill"
            viewBox="0 0 16 16"
          >
            <path
              d="M12 8a4 4 0 1 1-8 0 4 4 0 0 1 8 0zM8 0a.5.5 0 0 1 .5.5v2a.5.5 0 0 1-1 0v-2A.5.5 0 0 1 8 0zm0 13a.5.5 0 0 1 .5.5v2a.5.5 0 0 1-1 0v-2A.5.5 0 0 1 8 13zm8-5a.5.5 0 0 1-.5.5h-2a.5.5 0 0 1 0-1h2a.5.5 0 0 1 .5.5zM3 8a.5.5 0 0 1-.5.5h-2a.5.5 0 0 1 0-1h2A.5.5 0 0 1 3 8zm10.657-5.657a.5.5 0 0 1 0 .707l-1.414 1.415a.5.5 0 1 1-.707-.708l1.414-1.414a.5.5 0 0 1 .707 0zm-9.193 9.193a.5.5 0 0 1 0 .707L3.05 13.657a.5.5 0 0 1-.707-.707l1.414-1.414a.5.5 0 0 1 .707 0zm9.193 2.121a.5.5 0 0 1-.707 0l-1.414-1.414a.5.5 0 0 1 .707-.707l1.414 1.414a.5.5 0 0 1 0 .707zM4.464 4.465a.5.5 0 0 1-.707 0L2.343 3.05a.5.5 0 1 1 .707-.707l1.414 1.414a.5.5 0 0 1 0 .708z"
            />
          </svg>
        </div>
      </div>
    </div>
  </header>
`;

class MyCustomHeader extends HTMLElement {
  constructor() {
    super();
  }

  connectedCallback() {
    const shadowRoot = this.attachShadow({ mode: "open" });

    shadowRoot.appendChild(myHeader.content);
  }
}

customElements.define("my-custom-header", MyCustomHeader);

function toggleDarkTheme() {
  document.body.classList.toggle("dark-theme");

  const thisHeader = document.querySelector("my-custom-header").shadowRoot;
  thisHeader.querySelector("header").classList.toggle("dark-theme");
  thisHeader.querySelectorAll(".change-mode .item").forEach((icon) => {
    icon.classList.toggle("hidden");
  });
}
