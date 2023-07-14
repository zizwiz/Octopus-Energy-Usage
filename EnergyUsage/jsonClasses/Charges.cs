using System;

namespace EnergyUsage
{
    public class TariffRootobject
    {
        public string code { get; set; }
        public string full_name { get; set; }
        public string display_name { get; set; }
        public string description { get; set; }
        public bool is_variable { get; set; }
        public bool is_green { get; set; }
        public bool is_tracker { get; set; }
        public bool is_prepay { get; set; }
        public bool is_business { get; set; }
        public bool is_restricted { get; set; }
        public int term { get; set; }
        public DateTime available_from { get; set; }
        public object available_to { get; set; }
        public DateTime tariffs_active_at { get; set; }
        public Single_Register_Electricity_Tariffs single_register_electricity_tariffs { get; set; }
        public Dual_Register_Electricity_Tariffs dual_register_electricity_tariffs { get; set; }
        public Single_Register_Gas_Tariffs single_register_gas_tariffs { get; set; }
        public Sample_Quotes sample_quotes { get; set; }
        public Sample_Consumption sample_consumption { get; set; }
        public Link14[] links { get; set; }
        public string brand { get; set; }
    }

    public class Single_Register_Electricity_Tariffs
    {
        public _A _A { get; set; }
        public _B _B { get; set; }
        public _C _C { get; set; }
        public _D _D { get; set; }
        public _E _E { get; set; }
        public _F _F { get; set; }
        public _G _G { get; set; }
        public _H _H { get; set; }
        public _J _J { get; set; }
        public _K _K { get; set; }
        public _L _L { get; set; }
        public _M _M { get; set; }
        public _N _N { get; set; }
        public _P _P { get; set; }
    }

    public class _A
    {
        public Direct_Debit_Monthly direct_debit_monthly { get; set; }
    }

    public class Direct_Debit_Monthly
    {
        public string code { get; set; }
        public float standing_charge_exc_vat { get; set; }
        public float standing_charge_inc_vat { get; set; }
        public int online_discount_exc_vat { get; set; }
        public int online_discount_inc_vat { get; set; }
        public int dual_fuel_discount_exc_vat { get; set; }
        public int dual_fuel_discount_inc_vat { get; set; }
        public int exit_fees_exc_vat { get; set; }
        public int exit_fees_inc_vat { get; set; }
        public string exit_fees_type { get; set; }
        public Link[] links { get; set; }
        public float standard_unit_rate_exc_vat { get; set; }
        public float standard_unit_rate_inc_vat { get; set; }
    }

    public class Link
    {
        public string href { get; set; }
        public string method { get; set; }
        public string rel { get; set; }
    }

    public class _B
    {
        public Direct_Debit_Monthly1 direct_debit_monthly { get; set; }
    }

    public class Direct_Debit_Monthly1
    {
        public string code { get; set; }
        public float standing_charge_exc_vat { get; set; }
        public float standing_charge_inc_vat { get; set; }
        public int online_discount_exc_vat { get; set; }
        public int online_discount_inc_vat { get; set; }
        public int dual_fuel_discount_exc_vat { get; set; }
        public int dual_fuel_discount_inc_vat { get; set; }
        public int exit_fees_exc_vat { get; set; }
        public int exit_fees_inc_vat { get; set; }
        public string exit_fees_type { get; set; }
        public Link1[] links { get; set; }
        public float standard_unit_rate_exc_vat { get; set; }
        public float standard_unit_rate_inc_vat { get; set; }
    }

    public class Link1
    {
        public string href { get; set; }
        public string method { get; set; }
        public string rel { get; set; }
    }

    public class _C
    {
        public Direct_Debit_Monthly2 direct_debit_monthly { get; set; }
    }

    public class Direct_Debit_Monthly2
    {
        public string code { get; set; }
        public float standing_charge_exc_vat { get; set; }
        public float standing_charge_inc_vat { get; set; }
        public int online_discount_exc_vat { get; set; }
        public int online_discount_inc_vat { get; set; }
        public int dual_fuel_discount_exc_vat { get; set; }
        public int dual_fuel_discount_inc_vat { get; set; }
        public int exit_fees_exc_vat { get; set; }
        public int exit_fees_inc_vat { get; set; }
        public string exit_fees_type { get; set; }
        public Link2[] links { get; set; }
        public float standard_unit_rate_exc_vat { get; set; }
        public float standard_unit_rate_inc_vat { get; set; }
    }

    public class Link2
    {
        public string href { get; set; }
        public string method { get; set; }
        public string rel { get; set; }
    }

    public class _D
    {
        public Direct_Debit_Monthly3 direct_debit_monthly { get; set; }
    }

    public class Direct_Debit_Monthly3
    {
        public string code { get; set; }
        public float standing_charge_exc_vat { get; set; }
        public float standing_charge_inc_vat { get; set; }
        public int online_discount_exc_vat { get; set; }
        public int online_discount_inc_vat { get; set; }
        public int dual_fuel_discount_exc_vat { get; set; }
        public int dual_fuel_discount_inc_vat { get; set; }
        public int exit_fees_exc_vat { get; set; }
        public int exit_fees_inc_vat { get; set; }
        public string exit_fees_type { get; set; }
        public Link3[] links { get; set; }
        public float standard_unit_rate_exc_vat { get; set; }
        public float standard_unit_rate_inc_vat { get; set; }
    }

    public class Link3
    {
        public string href { get; set; }
        public string method { get; set; }
        public string rel { get; set; }
    }

    public class _E
    {
        public Direct_Debit_Monthly4 direct_debit_monthly { get; set; }
    }

    public class Direct_Debit_Monthly4
    {
        public string code { get; set; }
        public float standing_charge_exc_vat { get; set; }
        public float standing_charge_inc_vat { get; set; }
        public int online_discount_exc_vat { get; set; }
        public int online_discount_inc_vat { get; set; }
        public int dual_fuel_discount_exc_vat { get; set; }
        public int dual_fuel_discount_inc_vat { get; set; }
        public int exit_fees_exc_vat { get; set; }
        public int exit_fees_inc_vat { get; set; }
        public string exit_fees_type { get; set; }
        public Link4[] links { get; set; }
        public float standard_unit_rate_exc_vat { get; set; }
        public float standard_unit_rate_inc_vat { get; set; }
    }

    public class Link4
    {
        public string href { get; set; }
        public string method { get; set; }
        public string rel { get; set; }
    }

    public class _F
    {
        public Direct_Debit_Monthly5 direct_debit_monthly { get; set; }
    }

    public class Direct_Debit_Monthly5
    {
        public string code { get; set; }
        public float standing_charge_exc_vat { get; set; }
        public float standing_charge_inc_vat { get; set; }
        public int online_discount_exc_vat { get; set; }
        public int online_discount_inc_vat { get; set; }
        public int dual_fuel_discount_exc_vat { get; set; }
        public int dual_fuel_discount_inc_vat { get; set; }
        public int exit_fees_exc_vat { get; set; }
        public int exit_fees_inc_vat { get; set; }
        public string exit_fees_type { get; set; }
        public Link5[] links { get; set; }
        public float standard_unit_rate_exc_vat { get; set; }
        public float standard_unit_rate_inc_vat { get; set; }
    }

    public class Link5
    {
        public string href { get; set; }
        public string method { get; set; }
        public string rel { get; set; }
    }

    public class _G
    {
        public Direct_Debit_Monthly6 direct_debit_monthly { get; set; }
    }

    public class Direct_Debit_Monthly6
    {
        public string code { get; set; }
        public float standing_charge_exc_vat { get; set; }
        public float standing_charge_inc_vat { get; set; }
        public int online_discount_exc_vat { get; set; }
        public int online_discount_inc_vat { get; set; }
        public int dual_fuel_discount_exc_vat { get; set; }
        public int dual_fuel_discount_inc_vat { get; set; }
        public int exit_fees_exc_vat { get; set; }
        public int exit_fees_inc_vat { get; set; }
        public string exit_fees_type { get; set; }
        public Link6[] links { get; set; }
        public float standard_unit_rate_exc_vat { get; set; }
        public float standard_unit_rate_inc_vat { get; set; }
    }

    public class Link6
    {
        public string href { get; set; }
        public string method { get; set; }
        public string rel { get; set; }
    }

    public class _H
    {
        public Direct_Debit_Monthly7 direct_debit_monthly { get; set; }
    }

    public class Direct_Debit_Monthly7
    {
        public string code { get; set; }
        public float standing_charge_exc_vat { get; set; }
        public float standing_charge_inc_vat { get; set; }
        public int online_discount_exc_vat { get; set; }
        public int online_discount_inc_vat { get; set; }
        public int dual_fuel_discount_exc_vat { get; set; }
        public int dual_fuel_discount_inc_vat { get; set; }
        public int exit_fees_exc_vat { get; set; }
        public int exit_fees_inc_vat { get; set; }
        public string exit_fees_type { get; set; }
        public Link7[] links { get; set; }
        public float standard_unit_rate_exc_vat { get; set; }
        public float standard_unit_rate_inc_vat { get; set; }
    }

    public class Link7
    {
        public string href { get; set; }
        public string method { get; set; }
        public string rel { get; set; }
    }

    public class _J
    {
        public Direct_Debit_Monthly8 direct_debit_monthly { get; set; }
    }

    public class Direct_Debit_Monthly8
    {
        public string code { get; set; }
        public float standing_charge_exc_vat { get; set; }
        public float standing_charge_inc_vat { get; set; }
        public int online_discount_exc_vat { get; set; }
        public int online_discount_inc_vat { get; set; }
        public int dual_fuel_discount_exc_vat { get; set; }
        public int dual_fuel_discount_inc_vat { get; set; }
        public int exit_fees_exc_vat { get; set; }
        public int exit_fees_inc_vat { get; set; }
        public string exit_fees_type { get; set; }
        public Link8[] links { get; set; }
        public float standard_unit_rate_exc_vat { get; set; }
        public float standard_unit_rate_inc_vat { get; set; }
    }

    public class Link8
    {
        public string href { get; set; }
        public string method { get; set; }
        public string rel { get; set; }
    }

    public class _K
    {
        public Direct_Debit_Monthly9 direct_debit_monthly { get; set; }
    }

    public class Direct_Debit_Monthly9
    {
        public string code { get; set; }
        public float standing_charge_exc_vat { get; set; }
        public float standing_charge_inc_vat { get; set; }
        public int online_discount_exc_vat { get; set; }
        public int online_discount_inc_vat { get; set; }
        public int dual_fuel_discount_exc_vat { get; set; }
        public int dual_fuel_discount_inc_vat { get; set; }
        public int exit_fees_exc_vat { get; set; }
        public int exit_fees_inc_vat { get; set; }
        public string exit_fees_type { get; set; }
        public Link9[] links { get; set; }
        public float standard_unit_rate_exc_vat { get; set; }
        public float standard_unit_rate_inc_vat { get; set; }
    }

    public class Link9
    {
        public string href { get; set; }
        public string method { get; set; }
        public string rel { get; set; }
    }

    public class _L
    {
        public Direct_Debit_Monthly10 direct_debit_monthly { get; set; }
    }

    public class Direct_Debit_Monthly10
    {
        public string code { get; set; }
        public float standing_charge_exc_vat { get; set; }
        public float standing_charge_inc_vat { get; set; }
        public int online_discount_exc_vat { get; set; }
        public int online_discount_inc_vat { get; set; }
        public int dual_fuel_discount_exc_vat { get; set; }
        public int dual_fuel_discount_inc_vat { get; set; }
        public int exit_fees_exc_vat { get; set; }
        public int exit_fees_inc_vat { get; set; }
        public string exit_fees_type { get; set; }
        public Link10[] links { get; set; }
        public float standard_unit_rate_exc_vat { get; set; }
        public float standard_unit_rate_inc_vat { get; set; }
    }

    public class Link10
    {
        public string href { get; set; }
        public string method { get; set; }
        public string rel { get; set; }
    }

    public class _M
    {
        public Direct_Debit_Monthly11 direct_debit_monthly { get; set; }
    }

    public class Direct_Debit_Monthly11
    {
        public string code { get; set; }
        public float standing_charge_exc_vat { get; set; }
        public float standing_charge_inc_vat { get; set; }
        public int online_discount_exc_vat { get; set; }
        public int online_discount_inc_vat { get; set; }
        public int dual_fuel_discount_exc_vat { get; set; }
        public int dual_fuel_discount_inc_vat { get; set; }
        public int exit_fees_exc_vat { get; set; }
        public int exit_fees_inc_vat { get; set; }
        public string exit_fees_type { get; set; }
        public Link11[] links { get; set; }
        public float standard_unit_rate_exc_vat { get; set; }
        public float standard_unit_rate_inc_vat { get; set; }
    }

    public class Link11
    {
        public string href { get; set; }
        public string method { get; set; }
        public string rel { get; set; }
    }

    public class _N
    {
        public Direct_Debit_Monthly12 direct_debit_monthly { get; set; }
    }

    public class Direct_Debit_Monthly12
    {
        public string code { get; set; }
        public float standing_charge_exc_vat { get; set; }
        public float standing_charge_inc_vat { get; set; }
        public int online_discount_exc_vat { get; set; }
        public int online_discount_inc_vat { get; set; }
        public int dual_fuel_discount_exc_vat { get; set; }
        public int dual_fuel_discount_inc_vat { get; set; }
        public int exit_fees_exc_vat { get; set; }
        public int exit_fees_inc_vat { get; set; }
        public string exit_fees_type { get; set; }
        public Link12[] links { get; set; }
        public float standard_unit_rate_exc_vat { get; set; }
        public float standard_unit_rate_inc_vat { get; set; }
    }

    public class Link12
    {
        public string href { get; set; }
        public string method { get; set; }
        public string rel { get; set; }
    }

    public class _P
    {
        public Direct_Debit_Monthly13 direct_debit_monthly { get; set; }
    }

    public class Direct_Debit_Monthly13
    {
        public string code { get; set; }
        public float standing_charge_exc_vat { get; set; }
        public float standing_charge_inc_vat { get; set; }
        public int online_discount_exc_vat { get; set; }
        public int online_discount_inc_vat { get; set; }
        public int dual_fuel_discount_exc_vat { get; set; }
        public int dual_fuel_discount_inc_vat { get; set; }
        public int exit_fees_exc_vat { get; set; }
        public int exit_fees_inc_vat { get; set; }
        public string exit_fees_type { get; set; }
        public Link13[] links { get; set; }
        public float standard_unit_rate_exc_vat { get; set; }
        public float standard_unit_rate_inc_vat { get; set; }
    }

    public class Link13
    {
        public string href { get; set; }
        public string method { get; set; }
        public string rel { get; set; }
    }

    public class Dual_Register_Electricity_Tariffs
    {
    }

    public class Single_Register_Gas_Tariffs
    {
    }

    public class Sample_Quotes
    {
        public _A1 _A { get; set; }
        public _B1 _B { get; set; }
        public _C1 _C { get; set; }
        public _D1 _D { get; set; }
        public _E1 _E { get; set; }
        public _F1 _F { get; set; }
        public _G1 _G { get; set; }
        public _H1 _H { get; set; }
        public _J1 _J { get; set; }
        public _K1 _K { get; set; }
        public _L1 _L { get; set; }
        public _M1 _M { get; set; }
        public _N1 _N { get; set; }
        public _P1 _P { get; set; }
    }

    public class _A1
    {
        public Direct_Debit_Monthly14 direct_debit_monthly { get; set; }
    }

    public class Direct_Debit_Monthly14
    {
        public Electricity_Single_Rate electricity_single_rate { get; set; }
    }

    public class Electricity_Single_Rate
    {
        public int annual_cost_inc_vat { get; set; }
        public int annual_cost_exc_vat { get; set; }
    }

    public class _B1
    {
        public Direct_Debit_Monthly15 direct_debit_monthly { get; set; }
    }

    public class Direct_Debit_Monthly15
    {
        public Electricity_Single_Rate1 electricity_single_rate { get; set; }
    }

    public class Electricity_Single_Rate1
    {
        public int annual_cost_inc_vat { get; set; }
        public int annual_cost_exc_vat { get; set; }
    }

    public class _C1
    {
        public Direct_Debit_Monthly16 direct_debit_monthly { get; set; }
    }

    public class Direct_Debit_Monthly16
    {
        public Electricity_Single_Rate2 electricity_single_rate { get; set; }
    }

    public class Electricity_Single_Rate2
    {
        public int annual_cost_inc_vat { get; set; }
        public int annual_cost_exc_vat { get; set; }
    }

    public class _D1
    {
        public Direct_Debit_Monthly17 direct_debit_monthly { get; set; }
    }

    public class Direct_Debit_Monthly17
    {
        public Electricity_Single_Rate3 electricity_single_rate { get; set; }
    }

    public class Electricity_Single_Rate3
    {
        public int annual_cost_inc_vat { get; set; }
        public int annual_cost_exc_vat { get; set; }
    }

    public class _E1
    {
        public Direct_Debit_Monthly18 direct_debit_monthly { get; set; }
    }

    public class Direct_Debit_Monthly18
    {
        public Electricity_Single_Rate4 electricity_single_rate { get; set; }
    }

    public class Electricity_Single_Rate4
    {
        public int annual_cost_inc_vat { get; set; }
        public int annual_cost_exc_vat { get; set; }
    }

    public class _F1
    {
        public Direct_Debit_Monthly19 direct_debit_monthly { get; set; }
    }

    public class Direct_Debit_Monthly19
    {
        public Electricity_Single_Rate5 electricity_single_rate { get; set; }
    }

    public class Electricity_Single_Rate5
    {
        public int annual_cost_inc_vat { get; set; }
        public int annual_cost_exc_vat { get; set; }
    }

    public class _G1
    {
        public Direct_Debit_Monthly20 direct_debit_monthly { get; set; }
    }

    public class Direct_Debit_Monthly20
    {
        public Electricity_Single_Rate6 electricity_single_rate { get; set; }
    }

    public class Electricity_Single_Rate6
    {
        public int annual_cost_inc_vat { get; set; }
        public int annual_cost_exc_vat { get; set; }
    }

    public class _H1
    {
        public Direct_Debit_Monthly21 direct_debit_monthly { get; set; }
    }

    public class Direct_Debit_Monthly21
    {
        public Electricity_Single_Rate7 electricity_single_rate { get; set; }
    }

    public class Electricity_Single_Rate7
    {
        public int annual_cost_inc_vat { get; set; }
        public int annual_cost_exc_vat { get; set; }
    }

    public class _J1
    {
        public Direct_Debit_Monthly22 direct_debit_monthly { get; set; }
    }

    public class Direct_Debit_Monthly22
    {
        public Electricity_Single_Rate8 electricity_single_rate { get; set; }
    }

    public class Electricity_Single_Rate8
    {
        public int annual_cost_inc_vat { get; set; }
        public int annual_cost_exc_vat { get; set; }
    }

    public class _K1
    {
        public Direct_Debit_Monthly23 direct_debit_monthly { get; set; }
    }

    public class Direct_Debit_Monthly23
    {
        public Electricity_Single_Rate9 electricity_single_rate { get; set; }
    }

    public class Electricity_Single_Rate9
    {
        public int annual_cost_inc_vat { get; set; }
        public int annual_cost_exc_vat { get; set; }
    }

    public class _L1
    {
        public Direct_Debit_Monthly24 direct_debit_monthly { get; set; }
    }

    public class Direct_Debit_Monthly24
    {
        public Electricity_Single_Rate10 electricity_single_rate { get; set; }
    }

    public class Electricity_Single_Rate10
    {
        public int annual_cost_inc_vat { get; set; }
        public int annual_cost_exc_vat { get; set; }
    }

    public class _M1
    {
        public Direct_Debit_Monthly25 direct_debit_monthly { get; set; }
    }

    public class Direct_Debit_Monthly25
    {
        public Electricity_Single_Rate11 electricity_single_rate { get; set; }
    }

    public class Electricity_Single_Rate11
    {
        public int annual_cost_inc_vat { get; set; }
        public int annual_cost_exc_vat { get; set; }
    }

    public class _N1
    {
        public Direct_Debit_Monthly26 direct_debit_monthly { get; set; }
    }

    public class Direct_Debit_Monthly26
    {
        public Electricity_Single_Rate12 electricity_single_rate { get; set; }
    }

    public class Electricity_Single_Rate12
    {
        public int annual_cost_inc_vat { get; set; }
        public int annual_cost_exc_vat { get; set; }
    }

    public class _P1
    {
        public Direct_Debit_Monthly27 direct_debit_monthly { get; set; }
    }

    public class Direct_Debit_Monthly27
    {
        public Electricity_Single_Rate13 electricity_single_rate { get; set; }
    }

    public class Electricity_Single_Rate13
    {
        public int annual_cost_inc_vat { get; set; }
        public int annual_cost_exc_vat { get; set; }
    }

    public class Sample_Consumption
    {
        public Electricity_Single_Rate14 electricity_single_rate { get; set; }
        public Electricity_Dual_Rate electricity_dual_rate { get; set; }
        public Dual_Fuel_Single_Rate dual_fuel_single_rate { get; set; }
        public Dual_Fuel_Dual_Rate dual_fuel_dual_rate { get; set; }
    }

    public class Electricity_Single_Rate14
    {
        public int electricity_standard { get; set; }
    }

    public class Electricity_Dual_Rate
    {
        public int electricity_day { get; set; }
        public int electricity_night { get; set; }
    }

    public class Dual_Fuel_Single_Rate
    {
        public int electricity_standard { get; set; }
        public int gas_standard { get; set; }
    }

    public class Dual_Fuel_Dual_Rate
    {
        public int electricity_day { get; set; }
        public int electricity_night { get; set; }
        public int gas_standard { get; set; }
    }

    public class Link14
    {
        public string href { get; set; }
        public string method { get; set; }
        public string rel { get; set; }
    }
}
