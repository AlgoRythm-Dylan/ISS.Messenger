const Handlebars = require("handlebars")

function render(source, data){
    let template = Handlebars.compile(source);
    return template(data);
}

module.exports = {
    render
}