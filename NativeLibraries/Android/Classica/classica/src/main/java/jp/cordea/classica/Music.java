package jp.cordea.classica;

import org.json.JSONException;
import org.json.JSONObject;

/**
 * Created by Yoshihiro Tanaka on 2017/02/13.
 */

public class Music {

    private int id;

    private int composerId;

    private String name;

    private int year;

    private String opusNumber;

    public int getId() {
        return id;
    }

    public int getComposerId() {
        return composerId;
    }

    public String getName() {
        return name;
    }

    public int getYear() {
        return year;
    }

    public String getOpusNumber() {
        return opusNumber;
    }

    public Music(int id, int composerId, String name, int year, String opusNumber) {
        this.id = id;
        this.composerId = composerId;
        this.name = name;
        this.year = year;
        this.opusNumber = opusNumber;
    }

    static Music fromJson(JSONObject jsonObject) {
        try {
            return new Music(
                    jsonObject.getInt("id"),
                    jsonObject.getInt("composerId"),
                    jsonObject.getString("name"),
                    jsonObject.getInt("year"),
                    jsonObject.getString("opusNumber")
            );
        } catch (JSONException e) {
            e.printStackTrace();
        }
        return null;
    }
}
