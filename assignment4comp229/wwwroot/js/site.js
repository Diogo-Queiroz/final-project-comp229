function validateFileType() {
  var fileName = document.getElementById("Icon").value;
  var idxDot = fileName.lastIndexOf(".") + 1;
  var extFile = fileName.substr(idxDot, fileName.length).toLowerCase();
  if (extFile === "jpg" || extFile === "jpeg" || extFile === "png" || extFile === "gif") {
    //TO DO
  } else {
    alert("Only jpg/jpeg and png files are allowed!");
  }
}