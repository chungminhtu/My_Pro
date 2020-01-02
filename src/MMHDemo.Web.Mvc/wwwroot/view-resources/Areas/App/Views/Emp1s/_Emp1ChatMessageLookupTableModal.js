(function ($) {
    app.modals.ChatMessageLookupTableModal = function () {

        var _modalManager;

        var _emp1sService = abp.services.app.emp1s;
        var _$chatMessageTable = $('#ChatMessageTable');

        this.init = function (modalManager) {
            _modalManager = modalManager;
        };


        var dataTable = _$chatMessageTable.DataTable({
            paging: true,
            serverSide: true,
            processing: true,
            listAction: {
                ajaxFunction: _emp1sService.getAllChatMessageForLookupTable,
                inputFilter: function () {
                    return {
                        filter: $('#ChatMessageTableFilter').val()
                    };
                }
            },
            columnDefs: [
                {
                    targets: 0,
                    data: null,
                    orderable: false,
                    autoWidth: false,
                    defaultContent: "<div class=\"text-center\"><input id='selectbtn' class='btn btn-success' type='button' width='25px' value='" + app.localize('Select') + "' /></div>"
                },
                {
                    autoWidth: false,
                    orderable: false,
                    targets: 1,
                    data: "displayName"
                }
            ]
        });

        $('#ChatMessageTable tbody').on('click', '[id*=selectbtn]', function () {
            var data = dataTable.row($(this).parents('tr')).data();
            _modalManager.setResult(data);
            _modalManager.close();
        });

        function getChatMessage() {
            dataTable.ajax.reload();
        }

        $('#GetChatMessageButton').click(function (e) {
            e.preventDefault();
            getChatMessage();
        });

        $('#SelectButton').click(function (e) {
            e.preventDefault();
        });

        $(document).keypress(function (e) {
            if (e.which === 13) {
                getChatMessage();
            }
        });

    };
})(jQuery);

