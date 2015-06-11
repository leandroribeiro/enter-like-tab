//<![CDATA[

JoelPurra.PlusAsTab.plusAsTab($("#form1 textarea, #form1 button"), false);

JoelPurra.PlusAsTab.plusAsTab($("#form1 :input"));

JoelPurra.PlusAsTab.setOptions({
    // Use enter instead of plus
    // Number 13 found through demo at
    // http://api.jquery.com/event.which/
    key: 13
});

$("#form1").submit(simulateSubmitting);

function simulateSubmitting(event) {
    event.preventDefault();

    if (confirm("Simulating that the form has been submitted.\n\nWould you like to reload the page?")) {
        location.reload();
    }

    return false;
}
//]]>