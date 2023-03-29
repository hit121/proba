const form = document.querySelector(".form__authorization ");
const listForm = form.querySelectorAll(".form__auth");
const userPassFirst = document.querySelector("#password1");
const userPassSecond = document.querySelector("#password2");
const mail = form.querySelector(".form__auth");
let flagPas = false;
let flagEmptyPole = false;

//проверка совпадения паролей
const listener = (e) => {
  userPassFirst.style =
    userPassFirst.value === userPassSecond.value
      ? "border: 1px solid green"
      : "border: 1px solid red";
  userPassSecond.style =
    userPassFirst.value === userPassSecond.value
      ? "border: 1px solid green"
      : "border: 1px solid red";
  flagPas = userPassFirst.value === userPassSecond.value ? true : false;
};
userPassSecond.addEventListener("input", listener);

//проверка перед отправкой
form.addEventListener("submit", function (e) {
  listForm.forEach((element) => {
    if (!element.value) {
      element.style = "border: 1px solid red";
      flagEmptyPole = false;
    }
  });
  if (!flagPas || !flagEmptyPole) {
    e.preventDefault();
    console.log(`поля незаполнены/некорректный пароль`);
  }
});

mail.addEventListener("click", function (e) {
  e.target.style = "border: 1px solid #d9d9d9";
  flagEmptyPole = true;
});

//значение рейтинга
const raiting = document.querySelector(".rating-area ");

raiting.addEventListener("click", function (e) {
  if (e.target.type === "radio") {
    console.log(e.target.id);
  }
});
