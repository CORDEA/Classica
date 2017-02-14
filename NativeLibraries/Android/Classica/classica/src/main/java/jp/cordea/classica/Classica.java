package jp.cordea.classica;

import android.content.Context;

import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.ArrayList;
import java.util.List;

/**
 * Created by Yoshihiro Tanaka on 2017/02/13.
 */

public class Classica {

    private Context context;

    private List<Music> musics;

    private List<Composer> composers;

    public List<Music> getMusics() {
        return musics;
    }

    public List<Composer> getComposers() {
        return composers;
    }

    public Classica(Context context) {
        this.context = context;
        composers = fromJson();
        List<Music> musics = new ArrayList<>();
        for (Composer composer : composers) {
            musics.addAll(composer.getMusics());
        }
        this.musics = musics;
    }

    public Composer getComposer(int id) {
        for (Composer composer : composers) {
            if (id == composer.getId()) {
                return composer;
            }
        }
        return null;
    }

    public Music getMusic(int id) {
        for (Music music : musics) {
            if (id == music.getId()) {
                return music;
            }
        }
        return null;
    }

    private List<Composer> fromJson() {
        BufferedReader reader = null;
        StringBuilder builder = new StringBuilder();
        try {
            reader = new BufferedReader(new InputStreamReader(context.getAssets().open("classica.json")));
            String line;
            while ((line = reader.readLine()) != null) {
                builder.append(line);
            }
        } catch (IOException e) {
            e.printStackTrace();
        } finally {
            if (reader != null) {
                try {
                    reader.close();
                } catch (IOException e) {
                    e.printStackTrace();
                }
            }
        }

        List<Composer> composers = new ArrayList<>();
        String jsonString = builder.toString();
        try {
            JSONObject jsonObject = new JSONObject(jsonString);
            JSONArray array = jsonObject.getJSONArray("composers");
            for (int i = 0; i < array.length(); i++) {
                composers.add(Composer.fromJson(array.getJSONObject(i)));
            }
        } catch (JSONException e) {
            e.printStackTrace();
        }
        return composers;
    }

}
