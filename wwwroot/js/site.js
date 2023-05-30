const aeSearchForm = document.getElementById("aliexpress-search-form");

aeSearchForm.addEventListener("submit", onFormSubmit);

const onFormSubmit = (event) => {
    event.preventDefault();
    const data = new FormData(event.target);
    console.log(data);
};
