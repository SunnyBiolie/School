let myMenu = {
  laptop: ["Dell", "Sony", "Acer", "Asus", "Apple"],
  smartphone: ["iPhone", "Galaxy S", "Sony Xperia"],
  tablet: ["Sony Z", "Galaxy Tab", "iPad"],
};

const $ = document.querySelector.bind(document);
const $$ = document.querySelectorAll.bind(document);

const contentContainer = $("#content-container");
const navTab = $("#nav-tab");
const navTabContent = $("#nav-tabContent");

var innerContentContainer = ``;
var innerNavTab = ``;
var innerNavTabContent = ``;

for (let keyName in myMenu) {
  console.log(keyName);
  innerNavTab += `
    <button
      class="nav-link col-4 col-sm-12"
      id="nav-${keyName}-tab"
      data-bs-toggle="tab"
      data-bs-target="#nav-${keyName}"
      type="button"
      role="tab"
      aria-controls="nav-${keyName}"
      aria-selected="true"
    >
      ${keyName}
    </button>
  `;
}

navTab.innerHTML = innerNavTab;

for (var keyName in myMenu) {
  innerNavTabContent += `
    <div
      class="tab-pane fade show row"
      id="nav-${keyName}"
      role="tabpanel"
      aria-labelledby="nav-${keyName}-tab"
    >
      ${myMenu[keyName]
        .map((item) => {
          return `
            <div class="col-6 col-sm-3 p-1">
              <div class="border border-light">
                <p class="text-center">${item}</p>
              </div>
            </div>
          `;
        })
        .join(" ")}
    </div>
  `;
}

navTabContent.innerHTML = innerNavTabContent;
// console.log(innerNavTabContent);
