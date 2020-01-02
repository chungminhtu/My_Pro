(function () {
    $(function () {

        var _$emp1sTable = $('#Emp1sTable');
        var _emp1sService = abp.services.app.emp1s;
		
        $('.date-picker').datetimepicker({
            locale: abp.localization.currentLanguage.name,
            format: 'L'
        });

        var _permissions = {
            create: abp.auth.hasPermission('Pages.Emp1s.Create'),
            edit: abp.auth.hasPermission('Pages.Emp1s.Edit'),
            'delete': abp.auth.hasPermission('Pages.Emp1s.Delete')
        };

        var _createOrEditModal = new app.ModalManager({
            viewUrl: abp.appPath + 'App/Emp1s/CreateOrEditModal',
            scriptUrl: abp.appPath + 'view-resources/Areas/App/Views/Emp1s/_CreateOrEditModal.js',
            modalClass: 'CreateOrEditEmp1Modal'
        });

		 var _viewEmp1Modal = new app.ModalManager({
            viewUrl: abp.appPath + 'App/Emp1s/Viewemp1Modal',
            modalClass: 'ViewEmp1Modal'
        });

		
		

        var getDateFilter = function (element) {
            if (element.data("DateTimePicker").date() == null) {
                return null;
            }
            return element.data("DateTimePicker").date().format("YYYY-MM-DDT00:00:00Z"); 
        }

        var dataTable = _$emp1sTable.DataTable({
            paging: true,
            serverSide: true,
            processing: true,
            listAction: {
                ajaxFunction: _emp1sService.getAll,
                inputFilter: function () {
                    return {
					filter: $('#Emp1sTableFilter').val(),
					nameFilter: $('#NameFilterId').val(),
					rollFilter: $('#RollFilterId').val(),
					emailFilter: $('#EmailFilterId').val()
                    };
                }
            },
            columnDefs: [
                {
                    width: 120,
                    targets: 0,
                    data: null,
                    orderable: false,
                    autoWidth: false,
                    defaultContent: '',
                    rowAction: {
                        cssClass: 'btn btn-brand dropdown-toggle',
                        text: '<i class="fa fa-cog"></i> ' + app.localize('Actions') + ' <span class="caret"></span>',
                        items: [
						{
                                text: app.localize('View'),
                                action: function (data) {
                                    _viewEmp1Modal.open({ id: data.record.emp1.id });
                                }
                        },
						{
                            text: app.localize('Edit'),
                            visible: function () {
                                return _permissions.edit;
                            },
                            action: function (data) {
                                _createOrEditModal.open({ id: data.record.emp1.id });
                            }
                        }, 
						{
                            text: app.localize('Delete'),
                            visible: function () {
                                return _permissions.delete;
                            },
                            action: function (data) {
                                deleteEmp1(data.record.emp1);
                            }
                        }]
                    }
                },
					{
						targets: 1,
						 data: "emp1.name",
						 name: "name"   
					},
					{
						targets: 2,
						 data: "emp1.roll",
						 name: "roll"   
					},
					{
						targets: 3,
						 data: "emp1.email",
						 name: "email"   
					}
            ]
        });

        function getEmp1s() {
            dataTable.ajax.reload();
        }

        function deleteEmp1(emp1) {
            abp.message.confirm(
                '',
                app.localize('AreYouSure'),
                function (isConfirmed) {
                    if (isConfirmed) {
                        _emp1sService.delete({
                            id: emp1.id
                        }).done(function () {
                            getEmp1s(true);
                            abp.notify.success(app.localize('SuccessfullyDeleted'));
                        });
                    }
                }
            );
        }

		$('#ShowAdvancedFiltersSpan').click(function () {
            $('#ShowAdvancedFiltersSpan').hide();
            $('#HideAdvancedFiltersSpan').show();
            $('#AdvacedAuditFiltersArea').slideDown();
        });

        $('#HideAdvancedFiltersSpan').click(function () {
            $('#HideAdvancedFiltersSpan').hide();
            $('#ShowAdvancedFiltersSpan').show();
            $('#AdvacedAuditFiltersArea').slideUp();
        });

        $('#CreateNewEmp1Button').click(function () {
            _createOrEditModal.open();
        });

		$('#ExportToExcelButton').click(function () {
            _emp1sService
                .getEmp1sToExcel({
				filter : $('#Emp1sTableFilter').val(),
					nameFilter: $('#NameFilterId').val(),
					rollFilter: $('#RollFilterId').val(),
					emailFilter: $('#EmailFilterId').val()
				})
                .done(function (result) {
                    app.downloadTempFile(result);
                });
        });

        abp.event.on('app.createOrEditEmp1ModalSaved', function () {
            getEmp1s();
        });

		$('#GetEmp1sButton').click(function (e) {
            e.preventDefault();
            getEmp1s();
        });

		$(document).keypress(function(e) {
		  if(e.which === 13) {
			getEmp1s();
		  }
		});
    });
})();