var addbtn = document.querySelector("#addbutton");
var inpvalue = document.querySelector("#addinput");
var comp = document.querySelector(".components");

document.body.onkeydown = function (e) {
  var event = window.event || e;
  if (event.keyCode == 13) {
    addclickevent();
  }
};
var txt = inpvalue.value;

addbtn.addEventListener("click", () => {
  addclickevent();
});

function addclickevent() {
  var txt = inpvalue.value;
  inpvalue.value === "" ? alert("gecersiz deger !") : createlistelement(txt);
}

function createlistelement(t) {
  var ulist = document.createElement("ul");
  var llist = document.createElement("li");
  var deletebutton = document.createElement("button");
  llist.innerText = t;
  deletebutton.innerText = "DELETE";
  comp.appendChild(ulist);
  ulist.appendChild(llist);
  llist.appendChild(deletebutton);

  inpvalue.value = "";

  // delete element
  deletebutton.addEventListener("click", () => {
    ulist.removeChild(llist);
  });
}
