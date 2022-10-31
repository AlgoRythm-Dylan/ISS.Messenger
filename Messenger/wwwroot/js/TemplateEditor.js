const TemplateEditorTemplate = `<div id="editor-container"></div>





`;

var TemplateEditorConfig = window.TemplateEditorConfig || {};

class TemplateEditor extends HTMLElement {
    constructor() {
        super();

        this.editor = null;
        this.shadow = null;

    }
    connectedCallback() {
        this.shadow = this.attachShadow();
        this.shadow.innerHTML = TemplateEditorTemplate;
    }
}

customElements.define("template-editor", TemplateEditor);