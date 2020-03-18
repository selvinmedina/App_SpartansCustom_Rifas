using System.Web;
using System.Web.Optimization;

namespace App_SpartansCustom_Rifas
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            //------------------------------  PAGES ------------------------------//
            bundles.Add(new ScriptBundle("~/Scripts/pages/c3-chart-init").Include(
            "~/Scripts/pages/c3-chart-init.js"
            ));

            bundles.Add(new ScriptBundle("~/Scripts/pages/calendar-init").Include(
            "~/Scripts/pages/calendar-init.js"
            ));

            bundles.Add(new ScriptBundle("~/Scripts/pages/chartist.init").Include(
            "~/Scripts/pages/chartist.init.js"
            ));

            bundles.Add(new ScriptBundle("~/Scripts/pages/chartjs.init").Include(
            "~/Scripts/pages/chartjs.init.js"
            ));

            bundles.Add(new ScriptBundle("~/Scripts/pages/dashboard").Include(
            "~/Scripts/pages/dashboard.js"
            ));

            bundles.Add(new ScriptBundle("~/Scripts/pages/datatables.init").Include(
            "~/Scripts/pages/datatables.init.js"
            ));

            bundles.Add(new ScriptBundle("~/Scripts/pages/flot.init").Include(
            "~/Scripts/pages/flot.init.js"
            ));

            bundles.Add(new ScriptBundle("~/Scripts/pages/form-advanced").Include(
            "~/Scripts/pages/form-advanced.js"
            ));

            bundles.Add(new ScriptBundle("~/Scripts/pages/gmaps").Include(
            "~/Scripts/pages/gmaps.js"
            ));

            bundles.Add(new ScriptBundle("~/Scripts/pages/jvectormap.init").Include(
            "~/Scripts/pages/jvectormap.init.js"
            ));

            bundles.Add(new ScriptBundle("~/Scripts/pages/lightbox").Include(
            "~/Scripts/pages/lightbox.js"
            ));

            bundles.Add(new ScriptBundle("~/Scripts/pages/morris.init").Include(
            "~/Scripts/pages/morris.init.js"
            ));

            bundles.Add(new ScriptBundle("~/Scripts/pages/rangeslider-init").Include(
            "~/Scripts/pages/rangeslider-init.js"
            ));

            bundles.Add(new ScriptBundle("~/Scripts/pages/sweet-alert.init").Include(
            "~/Scripts/pages/sweet-alert.init.js"
            ));

            bundles.Add(new ScriptBundle("~/Scripts/pages/xeditable").Include(
            "~/Scripts/pages/xeditable.js"
            ));
            //------------------------------  PAGES ------------------------------//

            //------------------------------  PLUGINS ------------------------------//
            bundles.Add(new ScriptBundle("~/Scripts/app/CategoriaProductos").Include(
                    "~/Scripts/app/CategoriaProductos.js"));

            bundles.Add(new ScriptBundle("~/Scripts/plugins/bootstrap-colorpicker/js").Include(
                    "~/Scripts/plugins/bootstrap-colorpicker/js/bootstrap-colorpicker.js"
                    ,"~/Scripts/plugins/bootstrap-colorpicker/js/bootstrap-colorpicker.min.js"));

            bundles.Add(new ScriptBundle("~/Scripts/plugins/bootstrap-datepicker").Include(
               // "~/Scripts/plugins/bootstrap-datepicker/dist/js/bootstrap-datepicker.js"
               // ,"~/Scripts/plugins/bootstrap-datepicker/dist/js/bootstrap-datepicker.min.js"
               // ,"~/Scripts/plugins/bootstrap-datepicker/dist/locales/bootstrap-datepicker.ar.min.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/dist/locales/bootstrap-datepicker.az.min.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/dist/locales/bootstrap-datepicker.bg.min.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/dist/locales/bootstrap-datepicker.bs.min.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/dist/locales/bootstrap-datepicker.ca.min.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/dist/locales/bootstrap-datepicker.cs.min.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/dist/locales/bootstrap-datepicker.cy.min.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/dist/locales/bootstrap-datepicker.da.min.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/dist/locales/bootstrap-datepicker.de.min.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/dist/locales/bootstrap-datepicker.el.min.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/dist/locales/bootstrap-datepicker.en-GB.min.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/dist/locales/bootstrap-datepicker.es.min.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/dist/locales/bootstrap-datepicker.et.min.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/dist/locales/bootstrap-datepicker.eu.min.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/dist/locales/bootstrap-datepicker.fa.min.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/dist/locales/bootstrap-datepicker.fi.min.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/dist/locales/bootstrap-datepicker.fo.min.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/dist/locales/bootstrap-datepicker.fr-CH.min.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/dist/locales/bootstrap-datepicker.fr.min.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/dist/locales/bootstrap-datepicker.gl.min.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/dist/locales/bootstrap-datepicker.he.min.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/dist/locales/bootstrap-datepicker.hr.min.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/dist/locales/bootstrap-datepicker.hu.min.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/dist/locales/bootstrap-datepicker.hy.min.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/dist/locales/bootstrap-datepicker.id.min.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/dist/locales/bootstrap-datepicker.is.min.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/dist/locales/bootstrap-datepicker.it-CH.min.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/dist/locales/bootstrap-datepicker.it.min.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/dist/locales/bootstrap-datepicker.ja.min.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/dist/locales/bootstrap-datepicker.ka.min.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/dist/locales/bootstrap-datepicker.kh.min.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/dist/locales/bootstrap-datepicker.kk.min.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/dist/locales/bootstrap-datepicker.kr.min.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/dist/locales/bootstrap-datepicker.lt.min.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/dist/locales/bootstrap-datepicker.lv.min.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/dist/locales/bootstrap-datepicker.me.min.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/dist/locales/bootstrap-datepicker.mk.min.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/dist/locales/bootstrap-datepicker.ms.min.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/dist/locales/bootstrap-datepicker.nb.min.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/dist/locales/bootstrap-datepicker.nl-BE.min.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/dist/locales/bootstrap-datepicker.nl.min.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/dist/locales/bootstrap-datepicker.no.min.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/dist/locales/bootstrap-datepicker.pl.min.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/dist/locales/bootstrap-datepicker.pt-BR.min.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/dist/locales/bootstrap-datepicker.pt.min.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/dist/locales/bootstrap-datepicker.ro.min.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/dist/locales/bootstrap-datepicker.rs-latin.min.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/dist/locales/bootstrap-datepicker.rs.min.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/dist/locales/bootstrap-datepicker.ru.min.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/dist/locales/bootstrap-datepicker.sk.min.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/dist/locales/bootstrap-datepicker.sl.min.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/dist/locales/bootstrap-datepicker.sq.min.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/dist/locales/bootstrap-datepicker.sr-latin.min.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/dist/locales/bootstrap-datepicker.sr.min.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/dist/locales/bootstrap-datepicker.sv.min.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/dist/locales/bootstrap-datepicker.sw.min.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/dist/locales/bootstrap-datepicker.th.min.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/dist/locales/bootstrap-datepicker.tr.min.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/dist/locales/bootstrap-datepicker.uk.min.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/dist/locales/bootstrap-datepicker.vi.min.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/dist/locales/bootstrap-datepicker.zh-CN.min.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/dist/locales/bootstrap-datepicker.zh-TW.min.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/js/locales/bootstrap-datepicker.ar.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/js/locales/bootstrap-datepicker.az.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/js/locales/bootstrap-datepicker.bg.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/js/locales/bootstrap-datepicker.bs.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/js/locales/bootstrap-datepicker.ca.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/js/locales/bootstrap-datepicker.cs.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/js/locales/bootstrap-datepicker.cy.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/js/locales/bootstrap-datepicker.da.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/js/locales/bootstrap-datepicker.de.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/js/locales/bootstrap-datepicker.el.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/js/locales/bootstrap-datepicker.en-GB.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/js/locales/bootstrap-datepicker.es.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/js/locales/bootstrap-datepicker.et.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/js/locales/bootstrap-datepicker.eu.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/js/locales/bootstrap-datepicker.fa.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/js/locales/bootstrap-datepicker.fi.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/js/locales/bootstrap-datepicker.fo.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/js/locales/bootstrap-datepicker.fr-CH.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/js/locales/bootstrap-datepicker.fr.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/js/locales/bootstrap-datepicker.gl.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/js/locales/bootstrap-datepicker.he.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/js/locales/bootstrap-datepicker.hr.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/js/locales/bootstrap-datepicker.hu.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/js/locales/bootstrap-datepicker.hy.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/js/locales/bootstrap-datepicker.id.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/js/locales/bootstrap-datepicker.is.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/js/locales/bootstrap-datepicker.it-CH.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/js/locales/bootstrap-datepicker.it.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/js/locales/bootstrap-datepicker.ja.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/js/locales/bootstrap-datepicker.ka.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/js/locales/bootstrap-datepicker.kh.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/js/locales/bootstrap-datepicker.kk.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/js/locales/bootstrap-datepicker.kr.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/js/locales/bootstrap-datepicker.lt.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/js/locales/bootstrap-datepicker.lv.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/js/locales/bootstrap-datepicker.me.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/js/locales/bootstrap-datepicker.mk.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/js/locales/bootstrap-datepicker.ms.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/js/locales/bootstrap-datepicker.nb.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/js/locales/bootstrap-datepicker.nl-BE.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/js/locales/bootstrap-datepicker.nl.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/js/locales/bootstrap-datepicker.no.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/js/locales/bootstrap-datepicker.pl.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/js/locales/bootstrap-datepicker.pt-BR.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/js/locales/bootstrap-datepicker.pt.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/js/locales/bootstrap-datepicker.ro.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/js/locales/bootstrap-datepicker.rs-latin.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/js/locales/bootstrap-datepicker.rs.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/js/locales/bootstrap-datepicker.ru.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/js/locales/bootstrap-datepicker.sk.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/js/locales/bootstrap-datepicker.sl.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/js/locales/bootstrap-datepicker.sq.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/js/locales/bootstrap-datepicker.sr-latin.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/js/locales/bootstrap-datepicker.sr.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/js/locales/bootstrap-datepicker.sv.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/js/locales/bootstrap-datepicker.sw.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/js/locales/bootstrap-datepicker.th.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/js/locales/bootstrap-datepicker.tr.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/js/locales/bootstrap-datepicker.uk.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/js/locales/bootstrap-datepicker.vi.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/js/locales/bootstrap-datepicker.zh-CN.js"
               //,"~/Scripts/plugins/bootstrap-datepicker/js/locales/bootstrap-datepicker.zh-TW.js",
               "~/Scripts/plugins/bootstrap-datepicker/js/bootstrap-datepicker.js"
                ));


            bundles.Add(new ScriptBundle("~/Scripts/plugins/bootstrap-filestyle").Include(
                "~/Scripts/plugins/bootstrap-filestyle/js/bootstrap-filestyle.js"
                ,"~/Scripts/plugins/bootstrap-filestyle/js/bootstrap-filestyle.min.js"
                ));


            bundles.Add(new ScriptBundle("~/Scripts/plugins/bootstrap-maxlength").Include(
                "~/Scripts/plugins/bootstrap-maxlength/src/bootstrap-maxlength.js"
                ,"~/Scripts/plugins/bootstrap-maxlength/bootstrap-maxlength.js"
                ,"~/Scripts/plugins/bootstrap-maxlength/bootstrap-maxlength.min.js"
                ));


            bundles.Add(new ScriptBundle("~/Scripts/plugins/bootstrap-session-timeout").Include(
                "~/Scripts/plugins/bootstrap-session-timeout/bootstrap-session-timeout.js"
                ,"~/Scripts/plugins/bootstrap-session-timeout/bootstrap-session-timeout.min.js"
                ));


            bundles.Add(new ScriptBundle("~/Scripts/plugins/bootstrap-touchspin").Include(
                "~/Scripts/plugins/bootstrap-touchspin/js/jquery.bootstrap-touchspin.js"
                ,"~/Scripts/plugins/bootstrap-touchspin/js/jquery.bootstrap-touchspin.min.js"
                ));


            bundles.Add(new ScriptBundle("~/Scripts/plugins/c3").Include(
                "~/Scripts/plugins/c3/c3.js"
                ,"~/Scripts/plugins/c3/c3.min.js"
                ));


            bundles.Add(new ScriptBundle("~/Scripts/plugins/chart.js").Include(
                "~/Scripts/plugins/chart.js/Chart.bundle.js"
               ,"~/Scripts/plugins/chart.js/Chart.bundle.min.js"
               ,"~/Scripts/plugins/chart.js/Chart.js"
               ,"~/Scripts/plugins/chart.js/Chart.min.js"
                ));


            bundles.Add(new ScriptBundle("~/Scripts/plugins/chartist").Include(
                "~/Scripts/plugins/chartist/js/chartist-plugin-tooltip.min.js"
               ,"~/Scripts/plugins/chartist/js/chartist.js"
               ,"~/Scripts/plugins/chartist/js/chartist.min.js"
                ));


            bundles.Add(new ScriptBundle("~/Scripts/plugins/d3").Include(
                "~/Scripts/plugins/d3/d3.js"
                ,"~/Scripts/plugins/d3/d3.min.js"
                ));


            bundles.Add(new ScriptBundle("~/Scripts/plugins/datatables").Include(
                "~/Scripts/plugins/datatables/buttons.bootstrap4.min.js"
               ,"~/Scripts/plugins/datatables/buttons.colVis.min.js"
               ,"~/Scripts/plugins/datatables/buttons.html5.min.js"
               ,"~/Scripts/plugins/datatables/buttons.print.min.js"
               ,"~/Scripts/plugins/datatables/dataTables.bootstrap4.min.js"
               ,"~/Scripts/plugins/datatables/dataTables.buttons.min.js"
               ,"~/Scripts/plugins/datatables/dataTables.responsive.min.js"
               ,"~/Scripts/plugins/datatables/jquery.dataTables.min.js"
               ,"~/Scripts/plugins/datatables/jszip.min.js"
               ,"~/Scripts/plugins/datatables/pdfmake.min.js"
               ,"~/Scripts/plugins/datatables/responsive.bootstrap4.min.js"
               ,"~/Scripts/plugins/datatables/vfs_fonts.js"
                ));


            bundles.Add(new ScriptBundle("~/Scripts/plugins/dropzone").Include(
                "~/Scripts/plugins/dropzone/dist/min/dropzone-amd-module.min.js"
                ,"~/Scripts/plugins/dropzone/dist/min/dropzone.min.js"
                ,"~/Scripts/plugins/dropzone/dist/dropzone-amd-module.js"
                ,"~/Scripts/plugins/dropzone/dist/dropzone.js"
                ));


            bundles.Add(new ScriptBundle("~/Scripts/plugins/flot-chart").Include(
                "~/Scripts/plugins/flot-chart/curvedLines.js"
                ,"~/Scripts/plugins/flot-chart/jquery.flot.crosshair.js"
                ,"~/Scripts/plugins/flot-chart/jquery.flot.min.js"
                ,"~/Scripts/plugins/flot-chart/jquery.flot.orderBars.min.js"
                ,"~/Scripts/plugins/flot-chart/jquery.flot.pie.js"
                ,"~/Scripts/plugins/flot-chart/jquery.flot.resize.js"
                ,"~/Scripts/plugins/flot-chart/jquery.flot.selection.js"
                ,"~/Scripts/plugins/flot-chart/jquery.flot.stack.js"
                ,"~/Scripts/plugins/flot-chart/jquery.flot.time.js"
                ,"~/Scripts/plugins/flot-chart/jquery.flot.tooltip.min.js"
                ));



            bundles.Add(new ScriptBundle("~/Scripts/plugins/fullcalendar").Include(
                "~/Scripts/plugins/fullcalendar/js/fullcalendar.min.js"
                ));


            bundles.Add(new ScriptBundle("~/Scripts/plugins/gmaps").Include(
                "~/Scripts/plugins/gmaps/lib/gmaps.controls.js"
                ,"~/Scripts/plugins/gmaps/lib/gmaps.core.js"
                ,"~/Scripts/plugins/gmaps/lib/gmaps.events.js"
                ,"~/Scripts/plugins/gmaps/lib/gmaps.geofences.js"
                ,"~/Scripts/plugins/gmaps/lib/gmaps.geometry.js"
                ,"~/Scripts/plugins/gmaps/lib/gmaps.layers.js"
                ,"~/Scripts/plugins/gmaps/lib/gmaps.map_types.js"
                ,"~/Scripts/plugins/gmaps/lib/gmaps.markers.js"
                ,"~/Scripts/plugins/gmaps/lib/gmaps.native_extensions.js"
                ,"~/Scripts/plugins/gmaps/lib/gmaps.overlays.js"
                ,"~/Scripts/plugins/gmaps/lib/gmaps.routes.js"
                ,"~/Scripts/plugins/gmaps/lib/gmaps.static.js"
                ,"~/Scripts/plugins/gmaps/lib/gmaps.streetview.js"
                ,"~/Scripts/plugins/gmaps/lib/gmaps.styles.js"
                ,"~/Scripts/plugins/gmaps/lib/gmaps.utils.js"
                ,"~/Scripts/plugins/gmaps/gmaps.js"
                ,"~/Scripts/plugins/gmaps/gmaps.min.js"
                ));


            bundles.Add(new ScriptBundle("~/Scripts/plugins/ion-rangeslider").Include(
                "~/Scripts/plugins/ion-rangeslider/js/ion.rangeSlider.js"
                ,"~/Scripts/plugins/ion-rangeslider/js/ion.rangeSlider.min.js"
                ));


            bundles.Add(new ScriptBundle("~/Scripts/plugins/jquery-knob").Include(
                "~/Scripts/plugins/jquery-knob/excanvas.js"
                ,"~/Scripts/plugins/jquery-knob/jquery.knob.js"
                ));


            bundles.Add(new ScriptBundle("~/Scripts/plugins/jquery-sparkline").Include(
                "~/Scripts/plugins/jquery-sparkline/jquery.sparkline.min.js"
                ));


            bundles.Add(new ScriptBundle("~/Scripts/plugins/jquery-ui").Include(
                "~/Scripts/plugins/jquery-ui/jquery-ui.min.js"
                ));


            bundles.Add(new ScriptBundle("~/Scripts/plugins/jvectormap").Include(
                "~/Scripts/plugins/jvectormap/gdp-data.js"
                ,"~/Scripts/plugins/jvectormap/jquery-jvectormap-2.0.2.min.js"
                ,"~/Scripts/plugins/jvectormap/jquery-jvectormap-europe-mill-en.js"
                ,"~/Scripts/plugins/jvectormap/jquery-jvectormap-uk-mill-en.js"
                ,"~/Scripts/plugins/jvectormap/jquery-jvectormap-us-aea-en.js"
                ,"~/Scripts/plugins/jvectormap/jquery-jvectormap-us-il-chicago-mill-en.js"
                ,"~/Scripts/plugins/jvectormap/jquery-jvectormap-world-mill-en.js"
                ));


            bundles.Add(new ScriptBundle("~/Scripts/plugins/magnific-popup").Include(
                "~/Scripts/plugins/magnific-popup/jquery.magnific-popup.js"
                ,"~/Scripts/plugins/magnific-popup/jquery.magnific-popup.min.js"));


            bundles.Add(new ScriptBundle("~/Scripts/plugins/moment").Include(
                "~/Scripts/plugins/moment/moment.js"));


            bundles.Add(new ScriptBundle("~/Scripts/plugins/morris").Include(
                "~/Scripts/plugins/morris/morris.min.js"));


            bundles.Add(new ScriptBundle("~/Scripts/plugins/parsleyjs").Include(
                "~/Scripts/plugins/parsleyjs/parsley.min.js"));


            bundles.Add(new ScriptBundle("~/Scripts/plugins/raphael").Include(
                "~/Scripts/plugins/raphael/raphael-min.js"));


            bundles.Add(new ScriptBundle("~/Scripts/plugins/RWD-Table-Patterns").Include(
                "~/Scripts/plugins/RWD-Table-Patterns/dist/js/rwd-table.js"
                ,"~/Scripts/plugins/RWD-Table-Patterns/dist/js/rwd-table.min.js"
                ,"~/Scripts/plugins/RWD-Table-Patterns/src/js/rwd-table.js"));


            bundles.Add(new StyleBundle("~/Scripts/plugins/select2/css").Include(
                "~/Scripts/plugins/select2/css/select2.css"
                ,"~/Scripts/plugins/select2/css/select2.min.css"));


            bundles.Add(new ScriptBundle("~/Scripts/plugins/select2/js").Include(
                //"~/Scripts/plugins/select2/js/i18n/af.js"
                //, "~/Scripts/plugins/select2/js/i18n/ar.js"
                //, "~/Scripts/plugins/select2/js/i18n/az.js"
                //, "~/Scripts/plugins/select2/js/i18n/bg.js"
                //, "~/Scripts/plugins/select2/js/i18n/bs.js"
                //, "~/Scripts/plugins/select2/js/i18n/ca.js"
                //, "~/Scripts/plugins/select2/js/i18n/cs.js"
                //, "~/Scripts/plugins/select2/js/i18n/da.js"
                //, "~/Scripts/plugins/select2/js/i18n/de.js"
                //, "~/Scripts/plugins/select2/js/i18n/dsb.js"
                //, "~/Scripts/plugins/select2/js/i18n/el.js"
                //, "~/Scripts/plugins/select2/js/i18n/en.js"
                //, "~/Scripts/plugins/select2/js/i18n/es.js"
                //, "~/Scripts/plugins/select2/js/i18n/et.js"
                //, "~/Scripts/plugins/select2/js/i18n/eu.js"
                //, "~/Scripts/plugins/select2/js/i18n/fa.js"
                //, "~/Scripts/plugins/select2/js/i18n/fi.js"
                //, "~/Scripts/plugins/select2/js/i18n/fr.js"
                //, "~/Scripts/plugins/select2/js/i18n/gl.js"
                //, "~/Scripts/plugins/select2/js/i18n/he.js"
                //, "~/Scripts/plugins/select2/js/i18n/hi.js"
                //, "~/Scripts/plugins/select2/js/i18n/hr.js"
                //, "~/Scripts/plugins/select2/js/i18n/hsb.js"
                //, "~/Scripts/plugins/select2/js/i18n/hu.js"
                //, "~/Scripts/plugins/select2/js/i18n/hy.js"
                //, "~/Scripts/plugins/select2/js/i18n/id.js"
                //, "~/Scripts/plugins/select2/js/i18n/is.js"
                //, "~/Scripts/plugins/select2/js/i18n/it.js"
                //, "~/Scripts/plugins/select2/js/i18n/ja.js"
                //, "~/Scripts/plugins/select2/js/i18n/km.js"
                //, "~/Scripts/plugins/select2/js/i18n/ko.js"
                //, "~/Scripts/plugins/select2/js/i18n/lt.js"
                //, "~/Scripts/plugins/select2/js/i18n/lv.js"
                //, "~/Scripts/plugins/select2/js/i18n/mk.js"
                //, "~/Scripts/plugins/select2/js/i18n/ms.js"
                //, "~/Scripts/plugins/select2/js/i18n/nb.js"
                //, "~/Scripts/plugins/select2/js/i18n/nl.js"
                //, "~/Scripts/plugins/select2/js/i18n/pl.js"
                //, "~/Scripts/plugins/select2/js/i18n/ps.js"
                //, "~/Scripts/plugins/select2/js/i18n/pt-BR.js"
                //, "~/Scripts/plugins/select2/js/i18n/pt.js"
                //, "~/Scripts/plugins/select2/js/i18n/ro.js"
                //, "~/Scripts/plugins/select2/js/i18n/ru.js"
                //, "~/Scripts/plugins/select2/js/i18n/sk.js"
                //, "~/Scripts/plugins/select2/js/i18n/sl.js"
                //, "~/Scripts/plugins/select2/js/i18n/sr-Cyrl.js"
                //, "~/Scripts/plugins/select2/js/i18n/sr.js"
                //, "~/Scripts/plugins/select2/js/i18n/sv.js"
                //, "~/Scripts/plugins/select2/js/i18n/th.js"
                //, "~/Scripts/plugins/select2/js/i18n/tk.js"
                //, "~/Scripts/plugins/select2/js/i18n/tr.js"
                //, "~/Scripts/plugins/select2/js/i18n/uk.js"
                //, "~/Scripts/plugins/select2/js/i18n/vi.js"
                //, "~/Scripts/plugins/select2/js/i18n/zh-CN.js"
                //, "~/Scripts/plugins/select2/js/i18n/zh-TW.js"
                //, "~/Scripts/plugins/select2/js/select2.full.js"
                //, "~/Scripts/plugins/select2/js/select2.full.min.js"
                //, "~/Scripts/plugins/select2/js/select2.js",
                 "~/Scripts/plugins/select2/js/select2.min.js"
                ));


            bundles.Add(new StyleBundle("~/Scripts/plugins/summernote/css").Include(
                "~/Scripts/plugins/summernote/summernote-bs4.css"
                ));


            bundles.Add(new ScriptBundle("~/Scripts/plugins/summernote/js").Include(
                //"~/Scripts/plugins/summernote/lang/summernote-ar-AR.js"
                //, "~/Scripts/plugins/summernote/lang/summernote-ar-AR.min.js"
                //, "~/Scripts/plugins/summernote/lang/summernote-bg-BG.js"
                //, "~/Scripts/plugins/summernote/lang/summernote-bg-BG.min.js"
                //, "~/Scripts/plugins/summernote/lang/summernote-ca-ES.js"
                //, "~/Scripts/plugins/summernote/lang/summernote-ca-ES.min.js"
                //, "~/Scripts/plugins/summernote/lang/summernote-cs-CZ.js"
                //, "~/Scripts/plugins/summernote/lang/summernote-cs-CZ.min.js"
                //, "~/Scripts/plugins/summernote/lang/summernote-da-DK.js"
                //, "~/Scripts/plugins/summernote/lang/summernote-da-DK.min.js"
                //, "~/Scripts/plugins/summernote/lang/summernote-de-DE.js"
                //, "~/Scripts/plugins/summernote/lang/summernote-de-DE.min.js"
                //, "~/Scripts/plugins/summernote/lang/summernote-el-GR.js"
                //, "~/Scripts/plugins/summernote/lang/summernote-el-GR.min.js"
                //, "~/Scripts/plugins/summernote/lang/summernote-es-ES.js"
                //, "~/Scripts/plugins/summernote/lang/summernote-es-ES.min.js"
                //, "~/Scripts/plugins/summernote/lang/summernote-es-EU.js"
                //, "~/Scripts/plugins/summernote/lang/summernote-es-EU.min.js"
                //, "~/Scripts/plugins/summernote/lang/summernote-fa-IR.js"
                //, "~/Scripts/plugins/summernote/lang/summernote-fa-IR.min.js"
                //, "~/Scripts/plugins/summernote/lang/summernote-fi-FI.js"
                //, "~/Scripts/plugins/summernote/lang/summernote-fi-FI.min.js"
                //, "~/Scripts/plugins/summernote/lang/summernote-fr-FR.js"
                //, "~/Scripts/plugins/summernote/lang/summernote-fr-FR.min.js"
                //, "~/Scripts/plugins/summernote/lang/summernote-gl-ES.js"
                //, "~/Scripts/plugins/summernote/lang/summernote-gl-ES.min.js"
                //, "~/Scripts/plugins/summernote/lang/summernote-he-IL.js"
                //, "~/Scripts/plugins/summernote/lang/summernote-he-IL.min.js"
                //, "~/Scripts/plugins/summernote/lang/summernote-hr-HR.js"
                //, "~/Scripts/plugins/summernote/lang/summernote-hr-HR.min.js"
                //, "~/Scripts/plugins/summernote/lang/summernote-hu-HU.js"
                //, "~/Scripts/plugins/summernote/lang/summernote-hu-HU.min.js"
                //, "~/Scripts/plugins/summernote/lang/summernote-id-ID.js"
                //, "~/Scripts/plugins/summernote/lang/summernote-id-ID.min.js"
                //, "~/Scripts/plugins/summernote/lang/summernote-it-IT.js"
                //, "~/Scripts/plugins/summernote/lang/summernote-it-IT.min.js"
                //, "~/Scripts/plugins/summernote/lang/summernote-ja-JP.js"
                //, "~/Scripts/plugins/summernote/lang/summernote-ja-JP.min.js"
                //, "~/Scripts/plugins/summernote/lang/summernote-ko-KR.js"
                //, "~/Scripts/plugins/summernote/lang/summernote-ko-KR.min.js"
                //, "~/Scripts/plugins/summernote/lang/summernote-lt-LT.js"
                //, "~/Scripts/plugins/summernote/lang/summernote-lt-LT.min.js"
                //, "~/Scripts/plugins/summernote/lang/summernote-lt-LV.js"
                //, "~/Scripts/plugins/summernote/lang/summernote-lt-LV.min.js"
                //, "~/Scripts/plugins/summernote/lang/summernote-mn-MN.js"
                //, "~/Scripts/plugins/summernote/lang/summernote-mn-MN.min.js"
                //, "~/Scripts/plugins/summernote/lang/summernote-nb-NO.js"
                //, "~/Scripts/plugins/summernote/lang/summernote-nb-NO.min.js"
                //, "~/Scripts/plugins/summernote/lang/summernote-nl-NL.js"
                //, "~/Scripts/plugins/summernote/lang/summernote-nl-NL.min.js"
                //, "~/Scripts/plugins/summernote/lang/summernote-pl-PL.js"
                //, "~/Scripts/plugins/summernote/lang/summernote-pl-PL.min.js"
                //, "~/Scripts/plugins/summernote/lang/summernote-pt-BR.js"
                //, "~/Scripts/plugins/summernote/lang/summernote-pt-BR.min.js"
                //, "~/Scripts/plugins/summernote/lang/summernote-pt-PT.js"
                //, "~/Scripts/plugins/summernote/lang/summernote-pt-PT.min.js"
                //, "~/Scripts/plugins/summernote/lang/summernote-ro-RO.js"
                //, "~/Scripts/plugins/summernote/lang/summernote-ro-RO.min.js"
                //, "~/Scripts/plugins/summernote/lang/summernote-ru-RU.js"
                //, "~/Scripts/plugins/summernote/lang/summernote-ru-RU.min.js"
                //, "~/Scripts/plugins/summernote/lang/summernote-sk-SK.js"
                //, "~/Scripts/plugins/summernote/lang/summernote-sk-SK.min.js"
                //, "~/Scripts/plugins/summernote/lang/summernote-sl-SI.js"
                //, "~/Scripts/plugins/summernote/lang/summernote-sl-SI.min.js"
                //, "~/Scripts/plugins/summernote/lang/summernote-sr-RS-Latin.js"
                //, "~/Scripts/plugins/summernote/lang/summernote-sr-RS-Latin.min.js"
                //, "~/Scripts/plugins/summernote/lang/summernote-sr-RS.js"
                //, "~/Scripts/plugins/summernote/lang/summernote-sr-RS.min.js"
                //, "~/Scripts/plugins/summernote/lang/summernote-sv-SE.js"
                //, "~/Scripts/plugins/summernote/lang/summernote-sv-SE.min.js"
                //, "~/Scripts/plugins/summernote/lang/summernote-ta-IN.js"
                //, "~/Scripts/plugins/summernote/lang/summernote-ta-IN.min.js"
                //, "~/Scripts/plugins/summernote/lang/summernote-th-TH.js"
                //, "~/Scripts/plugins/summernote/lang/summernote-th-TH.min.js"
                //, "~/Scripts/plugins/summernote/lang/summernote-tr-TR.js"
                //, "~/Scripts/plugins/summernote/lang/summernote-tr-TR.min.js"
                //, "~/Scripts/plugins/summernote/lang/summernote-uk-UA.js"
                //, "~/Scripts/plugins/summernote/lang/summernote-uk-UA.min.js"
                //, "~/Scripts/plugins/summernote/lang/summernote-vi-VN.js"
                //, "~/Scripts/plugins/summernote/lang/summernote-vi-VN.min.js"
                //, "~/Scripts/plugins/summernote/lang/summernote-zh-CN.js"
                //, "~/Scripts/plugins/summernote/lang/summernote-zh-CN.min.js"
                //, "~/Scripts/plugins/summernote/lang/summernote-zh-TW.js"
                //, "~/Scripts/plugins/summernote/lang/summernote-zh-TW.min.js",
                 "~/Scripts/plugins/summernote/summernote-bs4.min.js"
                ));


            bundles.Add(new StyleBundle("~/Scripts/plugins/sweet-alert2/css").Include(
                "~/Scripts/plugins/sweet-alert2/sweetalert2.css"
                , "~/Scripts/plugins/sweet-alert2/sweetalert2.min.css"
                ));


            bundles.Add(new ScriptBundle("~/Scripts/plugins/sweet-alert2/Js").Include(
                //"~/Scripts/plugins/sweet-alert2/sweetalert2.all.min.js"
                //, "~/Scripts/plugins/sweet-alert2/sweetalert2.common.js"
                //, "~/Scripts/plugins/sweet-alert2/sweetalert2.js",
                 "~/Scripts/plugins/sweet-alert2/sweetalert2.min.js"
                ));


            bundles.Add(new ScriptBundle("~/Scripts/plugins/tiny-editable").Include(
                "~/Scripts/plugins/tiny-editable/mindmup-editabletable.js"
                , "~/Scripts/plugins/tiny-editable/numeric-input-example.js"
                ));


            bundles.Add(new StyleBundle("~/Scripts/plugins/tinymce/css").Include(
                "~/Scripts/plugins/tinymce/plugins/codesample/css/prism.css"
                ,"~/Scripts/plugins/tinymce/plugins/visualblocks/css/visualblocks.css"
                ,"~/Scripts/plugins/tinymce/skins/lightgray/content.inline.min.css"
                ,"~/Scripts/plugins/tinymce/skins/lightgray/content.min.css"
                ,"~/Scripts/plugins/tinymce/skins/lightgray/skin.ie7.min.css"
                ,"~/Scripts/plugins/tinymce/skins/lightgray/skin.min.css"
                , "~/Scripts/plugins/tinymce/themes/inlite/src/demo/css/demo.css"
                ));


            bundles.Add(new ScriptBundle("~/Scripts/plugins/tinymce/Js").Include(
                "~/Scripts/plugins/tinymce/plugins/advlist/plugin.min.js"
                //, "~/Scripts/plugins/tinymce/plugins/anchor/plugin.min.js"
                //, "~/Scripts/plugins/tinymce/plugins/autolink/plugin.min.js"
                //, "~/Scripts/plugins/tinymce/plugins/autoresize/plugin.min.js"
                //, "~/Scripts/plugins/tinymce/plugins/autosave/plugin.min.js"
                //, "~/Scripts/plugins/tinymce/plugins/bbcode/plugin.min.js"
                //, "~/Scripts/plugins/tinymce/plugins/charmap/plugin.min.js"
                //, "~/Scripts/plugins/tinymce/plugins/code/plugin.min.js"
                //, "~/Scripts/plugins/tinymce/plugins/codesample/plugin.min.js"
                //, "~/Scripts/plugins/tinymce/plugins/colorpicker/plugin.min.js"
                //, "~/Scripts/plugins/tinymce/plugins/contextmenu/plugin.min.js"
                //, "~/Scripts/plugins/tinymce/plugins/directionality/plugin.min.js"
                //, "~/Scripts/plugins/tinymce/plugins/emoticons/plugin.min.js"
                //, "~/Scripts/plugins/tinymce/plugins/example/plugin.min.js"
                //, "~/Scripts/plugins/tinymce/plugins/example_dependency/plugin.min.js"
                //, "~/Scripts/plugins/tinymce/plugins/fullpage/plugin.min.js"
                //, "~/Scripts/plugins/tinymce/plugins/fullscreen/plugin.min.js"
                //, "~/Scripts/plugins/tinymce/plugins/hr/plugin.min.js"
                //, "~/Scripts/plugins/tinymce/plugins/image/plugin.min.js"
                //, "~/Scripts/plugins/tinymce/plugins/imagetools/plugin.min.js"
                //, "~/Scripts/plugins/tinymce/plugins/importcss/plugin.min.js"
                //, "~/Scripts/plugins/tinymce/plugins/insertdatetime/plugin.min.js"
                //, "~/Scripts/plugins/tinymce/plugins/layer/plugin.min.js"
                //, "~/Scripts/plugins/tinymce/plugins/legacyoutput/plugin.min.js"
                //, "~/Scripts/plugins/tinymce/plugins/link/plugin.min.js"
                //, "~/Scripts/plugins/tinymce/plugins/lists/plugin.min.js"
                //, "~/Scripts/plugins/tinymce/plugins/media/plugin.min.js"
                //, "~/Scripts/plugins/tinymce/plugins/nonbreaking/plugin.min.js"
                //, "~/Scripts/plugins/tinymce/plugins/noneditable/plugin.min.js"
                //, "~/Scripts/plugins/tinymce/plugins/pagebreak/plugin.min.js"
                //, "~/Scripts/plugins/tinymce/plugins/paste/plugin.min.js"
                //, "~/Scripts/plugins/tinymce/plugins/preview/plugin.min.js"
                //, "~/Scripts/plugins/tinymce/plugins/print/plugin.min.js"
                //, "~/Scripts/plugins/tinymce/plugins/save/plugin.min.js"
                //, "~/Scripts/plugins/tinymce/plugins/searchreplace/plugin.min.js"
                //, "~/Scripts/plugins/tinymce/plugins/spellchecker/plugin.min.js"
                //, "~/Scripts/plugins/tinymce/plugins/tabfocus/plugin.min.js"
                //, "~/Scripts/plugins/tinymce/plugins/table/plugin.min.js"
                //, "~/Scripts/plugins/tinymce/plugins/template/plugin.min.js"
                //, "~/Scripts/plugins/tinymce/plugins/textcolor/plugin.min.js"
                //, "~/Scripts/plugins/tinymce/plugins/textpattern/plugin.min.js"
                //, "~/Scripts/plugins/tinymce/plugins/visualblocks/plugin.min.js"
                //, "~/Scripts/plugins/tinymce/plugins/visualchars/plugin.min.js"
                //, "~/Scripts/plugins/tinymce/plugins/wordcount/plugin.min.js"
                //, "~/Scripts/plugins/tinymce/themes/inlite/config/bolt/atomic.js"
                //, "~/Scripts/plugins/tinymce/themes/inlite/config/bolt/bootstrap-atomic.js"
                //, "~/Scripts/plugins/tinymce/themes/inlite/config/bolt/bootstrap-browser.js"
                //, "~/Scripts/plugins/tinymce/themes/inlite/config/bolt/bootstrap-demo.js"
                //, "~/Scripts/plugins/tinymce/themes/inlite/config/bolt/bootstrap-prod.js"
                //, "~/Scripts/plugins/tinymce/themes/inlite/config/bolt/browser.js"
                //, "~/Scripts/plugins/tinymce/themes/inlite/config/bolt/demo.js"
                //, "~/Scripts/plugins/tinymce/themes/inlite/config/bolt/prod.js"
                //, "~/Scripts/plugins/tinymce/themes/inlite/config/dent/depend.js"
                //, "~/Scripts/plugins/tinymce/themes/inlite/scratch/compile/bootstrap.js"
                //, "~/Scripts/plugins/tinymce/themes/inlite/scratch/compile/theme.js"
                //, "~/Scripts/plugins/tinymce/themes/inlite/scratch/inline/theme.js"
                //, "~/Scripts/plugins/tinymce/themes/inlite/scratch/inline/theme.raw.js"
                //, "~/Scripts/plugins/tinymce/themes/inlite/src/demo/js/tinymce/inlite/Demo.js"
                //, "~/Scripts/plugins/tinymce/themes/inlite/src/main/js/tinymce/inlite/alien/Arr.js"
                //, "~/Scripts/plugins/tinymce/themes/inlite/src/main/js/tinymce/inlite/alien/Bookmark.js"
                //, "~/Scripts/plugins/tinymce/themes/inlite/src/main/js/tinymce/inlite/alien/Unlink.js"
                //, "~/Scripts/plugins/tinymce/themes/inlite/src/main/js/tinymce/inlite/alien/Uuid.js"
                //, "~/Scripts/plugins/tinymce/themes/inlite/src/main/js/tinymce/inlite/core/Actions.js"
                //, "~/Scripts/plugins/tinymce/themes/inlite/src/main/js/tinymce/inlite/core/Convert.js"
                //, "~/Scripts/plugins/tinymce/themes/inlite/src/main/js/tinymce/inlite/core/ElementMatcher.js"
                //, "~/Scripts/plugins/tinymce/themes/inlite/src/main/js/tinymce/inlite/core/Layout.js"
                //, "~/Scripts/plugins/tinymce/themes/inlite/src/main/js/tinymce/inlite/core/Matcher.js"
                //, "~/Scripts/plugins/tinymce/themes/inlite/src/main/js/tinymce/inlite/core/Measure.js"
                //, "~/Scripts/plugins/tinymce/themes/inlite/src/main/js/tinymce/inlite/core/PredicateId.js"
                //, "~/Scripts/plugins/tinymce/themes/inlite/src/main/js/tinymce/inlite/core/SelectionMatcher.js"
                //, "~/Scripts/plugins/tinymce/themes/inlite/src/main/js/tinymce/inlite/core/SkinLoader.js"
                //, "~/Scripts/plugins/tinymce/themes/inlite/src/main/js/tinymce/inlite/core/UrlType.js"
                //, "~/Scripts/plugins/tinymce/themes/inlite/src/main/js/tinymce/inlite/file/Conversions.js"
                //, "~/Scripts/plugins/tinymce/themes/inlite/src/main/js/tinymce/inlite/file/Picker.js"
                //, "~/Scripts/plugins/tinymce/themes/inlite/src/main/js/tinymce/inlite/Theme.js"
                //, "~/Scripts/plugins/tinymce/themes/inlite/src/main/js/tinymce/inlite/ui/Buttons.js"
                //, "~/Scripts/plugins/tinymce/themes/inlite/src/main/js/tinymce/inlite/ui/Forms.js"
                //, "~/Scripts/plugins/tinymce/themes/inlite/src/main/js/tinymce/inlite/ui/Panel.js"
                //, "~/Scripts/plugins/tinymce/themes/inlite/src/main/js/tinymce/inlite/ui/Toolbar.js"
                //, "~/Scripts/plugins/tinymce/themes/inlite/src/test/js/atomic/alien/ArrTest.js"
                //, "~/Scripts/plugins/tinymce/themes/inlite/src/test/js/atomic/alien/UuidTest.js"
                //, "~/Scripts/plugins/tinymce/themes/inlite/src/test/js/atomic/core/ConvertTest.js"
                //, "~/Scripts/plugins/tinymce/themes/inlite/src/test/js/atomic/core/MatcherTest.js"
                //, "~/Scripts/plugins/tinymce/themes/inlite/src/test/js/atomic/core/UrlTypeTest.js"
                //, "~/Scripts/plugins/tinymce/themes/inlite/src/test/js/browser/alien/BookmarkTest.js"
                //, "~/Scripts/plugins/tinymce/themes/inlite/src/test/js/browser/alien/UnlinkTest.js"
                //, "~/Scripts/plugins/tinymce/themes/inlite/src/test/js/browser/core/ActionsTest.js"
                //, "~/Scripts/plugins/tinymce/themes/inlite/src/test/js/browser/core/ElementMatcher.js"
                //, "~/Scripts/plugins/tinymce/themes/inlite/src/test/js/browser/core/LayoutTest.js"
                //, "~/Scripts/plugins/tinymce/themes/inlite/src/test/js/browser/core/MeasureTest.js"
                //, "~/Scripts/plugins/tinymce/themes/inlite/src/test/js/browser/core/PredicateIdTest.js"
                //, "~/Scripts/plugins/tinymce/themes/inlite/src/test/js/browser/core/SelectionMatcherTest.js"
                //, "~/Scripts/plugins/tinymce/themes/inlite/src/test/js/browser/file/ConversionsTest.js"
                //, "~/Scripts/plugins/tinymce/themes/inlite/src/test/js/browser/file/SelectionMatcher.js"
                //, "~/Scripts/plugins/tinymce/themes/inlite/src/test/js/browser/ThemeTest.js"
                , "~/Scripts/plugins/tinymce/themes/modern/theme.min.js"
                , "~/Scripts/plugins/tinymce/jquery.tinymce.min.js"
                , "~/Scripts/plugins/tinymce/tinymce.min.js"
                ));


            bundles.Add(new StyleBundle("~/Scripts/plugins/x-editable/css").Include(
                "~/Scripts/plugins/x-editable/css/bootstrap-editable.css"
                ));


            bundles.Add(new StyleBundle("~/Scripts/plugins/x-editable/js").Include(
                "~/Scripts/plugins/x-editable/js/bootstrap-editable.js"
                ,"~/Scripts/plugins/x-editable/js/bootstrap-editable.min.js"
                ));

            //------------------------------  PLUGINS ------------------------------//















            //BUNDLE LEXA RESPONSIVE
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                    "~/Scripts/jquery.min.js",
                    "~/Scripts/bootstrap.bundle.min.js",
                    "~/Scripts/jquery.slimscroll.js",
                    "~/Scripts/waves.min.js",
                    "~/plugins/jquery-sparkline/jquery.sparkline.min.js",
                    "~/Scripts/app.js"));

            //BUNDLE JQUERY VALIDATE
            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                    "~/Scripts/jquery.validate*"));
            
            //BUNDLE CSS STYLES
            bundles.Add(new StyleBundle("~/Content/css").Include(
                    "~/Content/css/bootstrap.min.css",
                    "~/Content/css/icons.css",
                    "~/Content/css/style.css",
                    "~/Content/scss/style.css"));

            //HABILITAR LA MANIFICACIÓN
            BundleTable.EnableOptimizations = true;

            //VALIDAR SI ESTA EN DEBUG PARA NO MANIFICAR
            #if (DEBUG)
                BundleTable.EnableOptimizations = false;
            #endif
        }
    }
}
