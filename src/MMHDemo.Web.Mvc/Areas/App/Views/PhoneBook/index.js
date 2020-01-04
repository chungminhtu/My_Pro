var _personService = abp.services.app.person;

$('#AllPeopleList button.delete-person').click(function (e) {
    e.preventDefault();

    var $listItem = $(this).closest('.list-group-item');
    var personId = $listItem.attr('data-person-id');

    abp.message.confirm(
        app.localize('AreYouSureToDeleteThePerson'),
        function (isConfirmed) {
            if (isConfirmed) {
                _personService.deletePerson({
                    id: personId
                }).done(function () {
                    abp.notify.info(app.localize('SuccessfullyDeleted'));
                    $listItem.remove();
                });
            }
        }
    );
});