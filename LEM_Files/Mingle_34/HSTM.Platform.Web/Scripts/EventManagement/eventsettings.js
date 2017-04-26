    var mHasUserClickedCrossOrgCheckbox = false;
    var mRegistrationAccessOptions;

    function removeAdminOnlyOption() {
        $("#RegistrationAccessOptionId option[value=1]").remove();
    }

    function changeSelfRegistrationAndAdminText(text) {
        $("#RegistrationAccessOptionId option[value=2]").text(text);
    }

            mRegistrationAccessOptions = $("#RegistrationAccessOptionId option").clone();

            if($("#IsGlobal").is(":checked")) {
                removeAdminOnlyOption();
                changeSelfRegistrationAndAdminText(uiResources.SelfRegistrationAndAdminOfHostingOrganization);
            }

            $("#IsGlobal").click(function () {
                if(!mHasUserClickedCrossOrgCheckbox && $(this).is(":checked")) {
                    $("#lnkOpenCrossOrganizationHelpModal").click();
                    mHasUserClickedCrossOrgCheckbox = true;
                }

                if($(this).is(":checked")) {
                    removeAdminOnlyOption();
                    changeSelfRegistrationAndAdminText(uiResources.SelfRegistrationAndAdminOfHostingOrganization);
                }
                else {
                    $("#RegistrationAccessOptionId").html(mRegistrationAccessOptions);
                    changeSelfRegistrationAndAdminText(uiResources.SelfRegistrationAndAdmin);
                }
            });
