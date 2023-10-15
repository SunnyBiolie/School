var popoverTriggerList = [].slice.call(
  document.querySelectorAll('[data-bs-toggle="popover"]')
);
var popoverList = popoverTriggerList.map(function (popoverTriggerEl) {
  let opts = {};
  if (popoverTriggerEl.hasAttribute("data-bs-content-id")) {
    opts.content = `<div id="list-heading-container">${
      document.getElementById(
        popoverTriggerEl.getAttribute("data-bs-content-id")
      ).innerHTML
    }</div>`;
    opts.html = true;
  }

  return new bootstrap.Popover(popoverTriggerEl, opts);
});

var btn = $('[data-bs-toggle="popover"][data-bs-content-id="popover-content"]');
var count = 0;

btn.onclick = () => {
  if (count == 0) {
    count++;
    var scrollSpy = new bootstrap.ScrollSpy(document.body, {
      target: "#list-heading-container",
    });
  }
};

btn.click();
