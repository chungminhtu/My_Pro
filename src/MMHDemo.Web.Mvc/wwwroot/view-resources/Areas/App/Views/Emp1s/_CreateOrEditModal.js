(function ($) {
    app.modals.CreateOrEditEmp1Modal = function () {

        var _emp1sService = abp.services.app.emp1s;

        var _modalManager;
        var _$emp1InformationForm = null;

		

        this.init = function (modalManager) {
            _modalManager = modalManager;

			var modal = _modalManager.getModal();
            modal.find('.date-picker').datetimepicker({
                locale: abp.localization.currentLanguage.name,
                format: 'L'
            });

            _$emp1InformationForm = _modalManager.getModal().find('form[name=Emp1InformationsForm]');
            _$emp1InformationForm.validate();
        };

		  

        this.save = function () {
            if (!_$emp1InformationForm.valid()) {
                return;
            }

            var emp1 = _$emp1InformationForm.serializeFormToObject();
			
			 _modalManager.setBusy(true);
			 _emp1sService.createOrEdit(
				emp1
			 ).done(function () {
               abp.notify.info(app.localize('SavedSuccessfully'));
               _modalManager.close();
               abp.event.trigger('app.createOrEditEmp1ModalSaved');
			 }).always(function () {
               _modalManager.setBusy(false);
			});
        };
    };
})(jQuery);