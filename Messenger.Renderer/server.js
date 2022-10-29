const express = require("express");
const { render } = require("./renderer");

let app = express();
app.use(express.json()); // Enable json parsing for HTTP requests

app.post("/render", async (request, response) => {
    response.send(render(request.body.template, request.body.data));
});

app.listen(8046);