package jp.cordea.classica;

import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

import java.util.ArrayList;
import java.util.List;

/**
 * Created by Yoshihiro Tanaka on 2017/02/13.
 */

public class Composer {

    private int id;

    private String name;

    private int birth;

    private int death;

    private List<Music> musics;

    public int getId() {
        return id;
    }

    public String getName() {
        return name;
    }

    public int getBirth() {
        return birth;
    }

    public int getDeath() {
        return death;
    }

    public List<Music> getMusics() {
        return musics;
    }

    public Composer(int id, String name, int birth, int death, List<Music> musics) {
        this.id = id;
        this.name = name;
        this.birth = birth;
        this.death = death;
        this.musics = musics;
    }

    static Composer fromJson(JSONObject jsonObject) {
        List<Music> musics = new ArrayList<>();
        try {
            int id = jsonObject.getInt("id");
            JSONArray array = jsonObject.getJSONArray("musics");
            for (int i = 0; i < array.length(); i++) {
                musics.add(Music.fromJson(array.getJSONObject(i), id));
            }

            return new Composer(
                    id,
                    jsonObject.getString("name"),
                    jsonObject.getInt("birth"),
                    jsonObject.getInt("death"),
                    musics
            );
        } catch (JSONException e) {
            e.printStackTrace();
        }
        return null;
    }

    public List<String> getMusicNames() {
        List<String> names = new ArrayList<>();
        for (Music music : musics) {
            names.add(music.getName());
        }
        return names;
    }

}
